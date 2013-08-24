using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	private CharacterController controller;
	
	public AudioClip jumpSound;
	
	private float speed = 14.0f;
	private float gravity = 20.0f;
	private float jumpSpeed = 14.0f;
	
	private Vector3 direction = Vector3.zero;
	
	void Start () {
		controller = GetComponent<CharacterController>();
	}

	// Update is called once per frame
	void Update () {
		Walk();
		controller.Move(direction * Time.deltaTime);
	}
	
	void Walk() {
		if (controller.isGrounded) {
			direction = new Vector3(Input.GetAxis("Horizontal"), 0, 0);
			direction = transform.TransformDirection(direction) * speed;
			
			if (Input.GetButton ("Jump")) {
				direction.y = jumpSpeed;
				audio.PlayOneShot (jumpSound);
			}
		}	
		direction.y -= gravity * Time.deltaTime;
	}
	
	void Fly() {
		direction = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis ("Vertical"), 0);
		direction = transform.TransformDirection(direction) * speed;
	}
}
