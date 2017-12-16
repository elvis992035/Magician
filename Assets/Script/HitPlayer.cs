using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitPlayer : MonoBehaviour {

	void OnTriggerEnter (Collider other)
	{
		if (other.gameObject.name == "Player(Clone)" ) 
		{
			other.GetComponent<Player> ().isDead = true;
			Debug.Log ("Player is Dead: " + other.GetComponent<Player> ().isDead);
		}
	} 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
