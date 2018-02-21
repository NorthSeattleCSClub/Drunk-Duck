using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		Movement();	
	}
	void Movement()
	{
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (Vector2.right * 20f * Time.deltaTime);
			transform.eulerAngles = new Vector2 (0, 0);
		}
		if (Input.GetKey (KeyCode.A)) {
			transform.Translate (Vector2.right * 20f * Time.deltaTime); 
			transform.eulerAngles = new Vector2 (0, 180);
		}
	}
}