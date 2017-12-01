using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour {
	public Transform target; 
	private float speed;
	// Use this for initialization
	void Start () {
		
		speed = 50;
		transform.LookAt (target);

	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.forward * (Time.deltaTime* speed));
	}
}
