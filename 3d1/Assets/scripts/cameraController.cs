using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {
	public GameObject camera;
	private Vector3 diff;

	// Use this for initialization
	void Start () {
		//offset es la diferencia de posiciones entre mi Gameobject camara y el gameobject que sigue.
		this.diff = transform.position - camera.transform.position;
	}
		
	
	// Update is called once per frame
	void FixedUpdate () {
		
		//orbit around
		if(Input.GetKeyDown("e") || Input.GetKey("e")){
			transform.RotateAround (camera.transform.position, new Vector3(0.0f, -90.0f, 0.0f), 100 * Time.deltaTime);
			this.diff = transform.position- camera.transform.position;
		}
		if(Input.GetKeyDown("q") || Input.GetKey("q")){
			transform.RotateAround (camera.transform.position, new Vector3(0.0f, 90.0f, 0.0f), 100 * Time.deltaTime);
			this.diff = transform.position- camera.transform.position;
		}

		transform.position = camera.transform.position + this.diff;
	}



}
