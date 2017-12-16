using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {

	Animator anim;

	void OnTriggerEnter (Collider other)
	{
		
		if (other.gameObject.name == "FireBolt(Clone)" && this.GetComponent<Enimies> ().isDead == false) 
			{
				this.GetComponent<Enimies> ().isDead = true;
				Debug.Log ("Hit");
		     	Destroy (gameObject);
				anim.SetBool ("isDead", true);
			    ScoreManager.score += 1;
				Destroy (other.gameObject);
			} 

			if (other.gameObject.name == "Player(Clone)" && this.GetComponent<Enimies> ().isDead == false) 
			{			
				other.GetComponent<Player> ().isDead = true;
				Debug.Log ("Player is Dead: " + other.GetComponent<Player> ().isDead);
			}
		
	} 

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
