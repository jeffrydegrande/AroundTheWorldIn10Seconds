using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	private CharacterController controller;
	
	public float speed = 6.0f;
	public float gravity = 20.0f;
	public float jumpSpeed = 8.0f;
	
	
	private Vector3 direction = Vector3.zero;
	
	void Start () {
		controller = GetComponent<CharacterController>();
	}
	
	void FixedUpdate() {
		// transform.position.z = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
		if (controller.isGrounded) {
			direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis ("Vertical"));
			direction = transform.TransformDirection(direction);
			direction *= speed;
			
			if (Input.GetButton ("Jump")) {
				direction.y = jumpSpeed;
			}
		
		}
		
		direction.y -= gravity * Time.deltaTime;
		controller.Move(direction * Time.deltaTime);
	}
}
