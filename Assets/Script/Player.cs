using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	private EffectSetting effectSetting;

    public GameObject Camera;

    private Vector3 offset;

	public GameObject Target;

	public GameObject[] Magic;

	private float MagicSpeed = 4;

    private void OnGUI()
    {
        
    }
    // Use this for initialization
    void Start () {
		
        offset = Camera.transform.position - transform.position;  // distance between char and camera

		var magicSet = Magic [0].GetComponent<EffectSetting> ();
		//MagicSpeed = magicSet.MoveSpeed;
    }

	// Update is called once per frame
	void Update () {


        float x = Input.GetAxis("Horizontal") * Time.deltaTime * 300.0f;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * 5.0f;



        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);

		if (Input.GetMouseButton (0)) {

			isFire ();
			Debug.Log (Target.transform.position);
		}


    }

	void isFire(){
		
		GameObject magic = Instantiate (Magic [0], transform.position, transform.rotation) as GameObject;

	}

    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        Camera.transform.position = transform.position + offset;
    }
}
