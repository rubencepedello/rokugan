using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour {


	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	void OnCollisionStay(Collision collision)
	{

		//Check for a match with the specific tag on any GameObject that collides with your GameObject
		if (collision.gameObject.tag == "Player")
		{
			//If the GameObject has the same tag as specified, output this message in the console
			Debug.Log("Do something else here");
			SceneManager.LoadScene ("garaje");
		}
	}
}
