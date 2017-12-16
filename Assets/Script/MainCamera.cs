using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour {


	public GameObject player;
	private Vector3 offset;

	// Use this for initialization
	void Start () {


		
	}

	// Update is called once per frame
	void Update () {
		
		player = GameObject.Find ("Player(Clone)");
		offset = this.transform.position - player.transform.position;  // distance between char and camera

	}

	void LateUpdate()
	{
		// Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
		this.transform.position = player.transform.position + offset;
	}
}
