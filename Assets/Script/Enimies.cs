using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enimies : MonoBehaviour 
{

	public GameObject player;

	public bool isDead = false;

	static Animator anim;

	// Use this for initialization
	void Start () 
	{
		player = GameObject.Find ("Player(Clone)");
		anim = GetComponent<Animator>();		
	}

	// Update is called once per frame
	void Update () 
	{

		if (isDead == true) return;

		Vector3 direction = player.transform.position - this.transform.position;

		// it's view
		float angle = Vector3.Angle (direction, this.transform.forward);

		if (Vector3.Distance (player.transform.position, this.transform.position) < 20 && angle < 60) 
		{
			
			direction.y = 0;

			this.transform.rotation = Quaternion.Slerp (this.transform.rotation, Quaternion.LookRotation (direction), 0.1f);

			anim.SetBool ("isIdle", false);

			if (direction.magnitude > 5) 
			{
				this.transform.Translate (0, 0, 0.05f);
				anim.SetBool ("isAttacking", false);
				anim.SetBool ("isWalking", true);

			} else 
			{
				anim.SetBool ("isWalking", false);
				anim.SetBool ("isAttacking", true);
			} 
		} else 
		{
			anim.SetBool ("isIdle", true);
			anim.SetBool ("isWalking", false);
			anim.SetBool ("isAttacking", false);
		}
	}

}
