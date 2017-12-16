using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManage : MonoBehaviour {

	public Transform[] spawnPoints;
	public GameObject[] Enemies; 
	public GameObject[] Clone;

	public GameObject player;

	public float spawnTime = 5f;



	// Use this for initialization
	void Start () {

		player = Instantiate (player, spawnPoints [2].transform.position, Quaternion.Euler (0, 0, 0)) as GameObject;
		player = GameObject.Find ("Player(Clone)");


	    InvokeRepeating("Spawn", spawnTime, spawnTime);
			
	}


	void Spawn ()
	{
		// If the player has no health left...
		if (player.GetComponent<Player> ().isDead == true) 
	    {
			// ... exit the function.
			return;
		}

		Clone [0] = Instantiate (Enemies[0], spawnPoints[0].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
		Clone [1] = Instantiate (Enemies[1], spawnPoints[1].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;

	}
}
