using UnityEngine;
using System.Collections;

public class GameOverScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		guiText.enabled = false;
	}
	
	public void PlayerHasDied()
	{
		guiText.enabled = true;
	}
}
