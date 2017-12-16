using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectSetting : MonoBehaviour {
	
	public enum EffectTypeEnum
	{
	   Projectile,
	   AOE,
	   Other
	};

	public enum DeactivationEnum
	{
       Deactivate,
	   DesstroyAfterCollision,
	   DestroyAfterTime,
	   Nothing
	};

	private Player player; 

	public EffectTypeEnum EffectType; 

	public float ColliderRadius = 0.2f;

	public float EffectRadius = 0;

	// Get the position of the movement of the notion vector, and not to follow to the target.
	public bool UseMoveVector;  

	public GameObject Target;

	public Vector3 MoveVector = Vector3.forward;

	public float MoveSpeed = 100;

	public bool IsVisible = true;

	public DeactivationEnum InstanceBehaviour = DeactivationEnum.Nothing;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Translate (MoveSpeed*Time.deltaTime, 0, MoveSpeed*Time.deltaTime);


	}
}
