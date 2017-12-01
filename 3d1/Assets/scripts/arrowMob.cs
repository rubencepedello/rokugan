using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class arrowMob : MonoBehaviour {

	public Transform target;
	public float speed;

	// Use this for initialization
	void Start () {
		//target = gameObject.name ("BallPosition");
		transform.getPosition.y = Ypos;
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (target);
		transform.Translate(Vector3.forward * (Time.deltaTime* speed));
	}
	void OnTriggerEnter(Collider c){
		if (c.gameObject.tag == "Player") {
			SceneManager.LoadScene ("garaje");

		}

	}
}
