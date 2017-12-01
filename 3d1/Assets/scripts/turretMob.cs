using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turretMob : MonoBehaviour {

	public float cadence;
	public Transform target;
	public GameObject turretProjectile;
	public Transform projSpawn;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Fire", 2.0f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (target);
		//Fire ();
	}
	void lateUpdate () {
		
		//yield return new WaitForSeconds(1);
	}

	void Fire (){
		var turretProjectil = (GameObject) Instantiate (
			turretProjectile,
			projSpawn.position,
			projSpawn.rotation);
		Destroy (turretProjectil, 10.0f);
	}
		

}
