using UnityEngine;
using System.Collections;

public class SmoothCameraFollow : MonoBehaviour {
	
	public float dampTime = 0.15f;
	
	private Vector3 velocity = Vector3.zero;
	public Transform target;
	
	void Start() {
	}
	
	void Update () {
		if (target) {
			Vector3 point = camera.WorldToViewportPoint(target.position);
			Vector3 delta = target.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z));
			
			Vector3 destination = transform.position + delta;
			destination.y = 0.0f;
			transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
		}
	}
}
