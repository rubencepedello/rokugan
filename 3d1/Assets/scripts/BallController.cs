using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour {

	public GameObject ballPosition;
	public float speed;
	private Rigidbody rb;
	private int isJumping;
	private int maxSaltos;
	public GameObject camera;
	private int dCount;
	public Vector3 jumpForce = new Vector3 ();


	// Use this for initialization
	void Start () {
		this.rb = GetComponent<Rigidbody>();
		isJumping = 0;
		maxSaltos = 1;
		Physics.gravity = new Vector3 (0.0f, -100.0f, 0.0f);
		dCount = 0;

		//this.ballPosition.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY;
	}
	

	void FixedUpdate () {
		

		if (maxSaltos >= 2) {
			if (Input.GetKeyDown ("w") || Input.GetKey ("w")) {
				rb.AddForce (ballPosition.transform.forward * (speed /2));
				rb.AddForce (-ballPosition.transform.right * (speed /2));
			}
			if (Input.GetKeyDown ("s") || Input.GetKey ("s")) {
				rb.AddForce (-ballPosition.transform.forward * (speed /2));
				rb.AddForce (ballPosition.transform.right * (speed /2));
			}
			if (Input.GetKeyDown ("d") || Input.GetKey ("d")) {
				rb.AddForce (ballPosition.transform.right * (speed /2));
				rb.AddForce (ballPosition.transform.forward * (speed /2));
			}
			if (Input.GetKeyDown ("a") || Input.GetKey ("a")) {
				rb.AddForce (-ballPosition.transform.right * (speed /2));
				rb.AddForce (-ballPosition.transform.forward * (speed /2));
			}
		}

		//rb.AddRelativeForce(Vector3.forward * speed);
		this.ballPosition.transform.position = rb.transform.position;

		//this is for jumps
		if(Input.GetKeyDown("space") && maxSaltos > 0){
			rb.AddForce(jumpForce, ForceMode.Impulse);
			maxSaltos--;
		}
	}
	void OnCollisionEnter(Collision c){
		this.maxSaltos = 2;
		if (c.gameObject.tag == "Mob") {
			SceneManager.LoadScene ("garaje");
		}
	}

	void OnTriggerEnter(Collider c){
		if (c.gameObject.tag == "coin") {
			c.gameObject.SetActive (false);
			dCount++;
			Debug.Log(dCount);
		}

	}

	void OnCollisionStay(Collision c){
		//rb.velocity /= 1.05f;
	}
}