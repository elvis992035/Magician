using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private EffectSetting effectSetting;

   // public GameObject Camera;
  //  private Vector3 offset;

	public float health = 10.0f; 

	public bool isDead = false;

	public GameObject Magic_Emitter;

	public GameObject[] Magic;

	public float MagicMoveForward;


    // Use this for initialization
    void Start () {
		
      //  offset = Camera.transform.position - transform.position;  // distance between char and camera

		//var magicSet = Magic [0].GetComponent<EffectSetting> ();
		//MagicSpeed = magicSet.MoveSpeed;
    }

	// Update is called once per frame
	void Update () {

        float x = Input.GetAxis("Horizontal") * Time.deltaTime * 300.0f;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * 5.0f;

        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);


		if (Input.GetKeyDown( "space" )) {

			GameObject Tem_Magic_Handler = Instantiate (Magic [0], Magic_Emitter.transform.position, Magic_Emitter.transform.rotation) as GameObject;

			//Tem_Magic_Handler.transform.Rotate (Vector3.left * 90);

			Rigidbody Tem_RigidBody = Tem_Magic_Handler.GetComponent<Rigidbody> ();

			Tem_RigidBody.AddForce (Tem_Magic_Handler.transform.forward * MagicMoveForward);

			Destroy ( Tem_Magic_Handler, 5.0f);

		
		}
    }

  /*  void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        Camera.transform.position = transform.position + offset;
    }*/
}
