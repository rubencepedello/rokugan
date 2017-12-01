using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mobs : MonoBehaviour {

	public float maxDistance;
	private Rigidbody rb;
	private float xPos;
	private float zPos;
	private float xRot;
	private float zRot;

	// Use this for initialization
	void Start () {
		this.rb = GetComponent<Rigidbody>();
		zPos = transform.position.z;
		xPos = transform.position.x;
		zRot = transform.rotation.z;
		xRot = transform.rotation.x;

	}
	
	// Update is called once per frame
	void Update () {
		
		transform.Rotate (Vector3.right, Time.deltaTime * 180);
		//GetComponent<Rigidbody>().rotation = ;

		/*if (goingUp == true && distance < maxDistance) {
			transform.position = new Vector3(0.0f, 1.0f, 0.0f);
		}
		if (distance > maxDistance) {
			goingUp = false;
		}

		if (goingUp == true && distance > maxDistance) {
			transform.position = new Vector3(0.0f, -1.0f, 0.0f);
		}
		if (distance < maxDistance) {
			goingUp = false;
		}*/

		//this is for jumps


	
		//transform.Translate (0, 0, -upwards * speed);
	}
	void OnCollisionEnter(Collision c){
		Vector3 jumpForce = new Vector3 (0.0f, maxDistance*100, 0.0f );
		rb.AddForce (jumpForce, ForceMode.Acceleration);
		//yield WaitForSeconds (5);

	}
}
