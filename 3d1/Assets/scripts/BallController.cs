using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour {

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
	}
	

	void FixedUpdate () {
		//global gravity
		Physics.gravity = new Vector3 (0.0f, -100.0f, 0.0f);
		//this is movement
		float horizontalAxis = Input.GetAxis("Horizontal");
		float verticalAxis = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(horizontalAxis, 0.0f,verticalAxis);
		rb.AddForce(movement * speed);
		//rb.AddRelativeForce(Vector3.forward * speed);

		//this is for jumps
		if(Input.GetKeyDown("space") && maxSaltos > 0){
			Vector3 jumpForce = new Vector3 (0.0f, 30.0f, 0.0f);
			rb.AddForce(jumpForce, ForceMode.Impulse);
			maxSaltos--;
		}
	}
	void OnCollisionEnter(Collision c){
		this.maxSaltos = 1;
	}
}