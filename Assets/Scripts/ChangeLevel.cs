using UnityEngine;
using System.Collections;

public class ChangeLevel : MonoBehaviour {

	public string nextLevel = null;

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			audio.Play ();
			if (nextLevel != null) {
				Application.LoadLevel(nextLevel);
			}
		}
	}
}
