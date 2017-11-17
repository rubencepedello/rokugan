using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {
	public GameObject ball;
	private Vector3 diff;

	// Use this for initialization
	void Start () {
		//offset es la diferencia de posiciones entre mi Gameobject camara y el gameobject que sigue.
		this.diff = transform.position - ball.transform.position;
	}
		
	
	// Update is called once per frame
	void LateUpdate () {
		
		//orbit around
		if(Input.GetKeyDown("r") || Input.GetKey("r")){
			transform.RotateAround (ball.transform.position, new Vector3(0.0f, -90.0f, 0.0f), 100 * Time.deltaTime);
			this.diff = transform.position- ball.transform.position;;
		}

		transform.position = ball.transform.position + this.diff;
	}



}
