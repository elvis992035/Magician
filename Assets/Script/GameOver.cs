using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameOver : MonoBehaviour {

	Text text;

	public GameObject player;

	// Use this for initialization
	void Start () {
		
		text = GetComponent<Text> ();



	}
	
	// Update is called once per frame
	void Update () {

		player = GameObject.Find ("Player(Clone)");

		if (player.GetComponent<Player> ().isDead == true) 
		{
			text.text = "Gave Over ";
		}
	}
}
