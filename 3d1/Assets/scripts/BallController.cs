using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

	public GameObject ballPosition;
	public float speed;
	private Rigidbody rb;
	private int isJumping;
	private int maxSaltos;
	public GameObject camera;


	// Use this for initialization
	void Start () {
		this.rb = GetComponent<Rigidbody>();
		isJumping = 0;
		maxSaltos = 1;
		Physics.gravity = new Vector3 (0.0f, -100.0f, 0.0f);

		//this.ballPosition.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY;
	}
	

	void FixedUpdate () {
		
		//global gravity
		//this is movement
		//float horizontalAxis = ballPosition.transform.eulerAngles.x;
		//float verticalAxis = ballPosition.transform.eulerAngles.y;
		//Vector3 movement = new Vector3(horizontalAxis, 0.0f,verticalAxis);
		if (Input.GetKeyDown ("w") || Input.GetKey ("w")) {
			rb.AddForce(ballPosition.transform.forward * speed);
		}
		if (Input.GetKeyDown ("s") || Input.GetKey ("s")) {
			rb.AddForce(-ballPosition.transform.forward * speed);
		}
		if (Input.GetKeyDown ("d") || Input.GetKey ("d")) {
			rb.AddForce(ballPosition.transform.right * speed);
		}
		if (Input.GetKeyDown ("a") || Input.GetKey ("a")) {
			rb.AddForce(-ballPosition.transform.right * speed);
		}

		//rb.AddRelativeForce(Vector3.forward * speed);
		this.ballPosition.transform.position = rb.transform.position;

		//this is for jumps
		if(Input.GetKeyDown("space") && maxSaltos > 0){
			Vector3 jumpForce = new Vector3 (0.0f, 30.0f, 0.0f);
			rb.AddForce(jumpForce, ForceMode.Impulse);
			maxSaltos--;
		}
	}
	void OnCollisionEnter(Collision c){
		this.maxSaltos = 2;
		if (c.gameObject.tag == "Mob") {
			rb.AddForce(-ballPosition.transform.forward * 1000, ForceMode.Impulse);
		}

	}

	void OnCollisionStay(Collision c){
		//rb.velocity /= 1.05f;
	}
}