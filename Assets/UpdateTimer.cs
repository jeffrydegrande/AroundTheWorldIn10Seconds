using UnityEngine;
using System.Collections;

public class UpdateTimer : MonoBehaviour {
	
	private float amount = 20000;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time < 10) { 
			guiText.text = Time.time.ToString("F2");
			return;
		}
		

		amount = 20000 - (Time.time - 10) * 800;
		
		if (amount < 0)
			amount = 0;
		
		guiText.text = "$" + amount.ToString("F0");		
	}
}
