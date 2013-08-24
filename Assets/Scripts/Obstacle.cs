using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {
	public AudioClip dieSound;
	public Player player;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	}
		
	void OnTriggerEnter(Collider other) {
		Debug.Log ("OnTriggerEnter");
		player.Die();
	}
}
