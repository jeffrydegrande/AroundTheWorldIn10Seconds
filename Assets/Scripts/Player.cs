using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	private CharacterController controller;
	
	public AudioClip jumpSound;
	public GameObject ui;
	
	private float speed = 14.0f;
	private float gravity = 20.0f;
	private float jumpSpeed = 14.0f;
	private bool playerAlive = true;
	
	
	private Vector3 direction = Vector3.zero;
	
	void Start () {
		controller = GetComponent<CharacterController>();
	}

	// Update is called once per frame
	void Update () {
		if (!playerAlive)
			return;
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
	
	
	public void Die() {
		direction = Vector3.zero;
		playerAlive = false;
		
		if (ui != null) {
			ui.BroadcastMessage("PlayerHasDied");
		}
	}
}
