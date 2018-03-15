using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class KillMonster : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public string gameOver;
	void OnTriggerEnter2D(Collider2D other)
	{
        if(other.tag == "player")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(gameOver);
        }
		
}
}