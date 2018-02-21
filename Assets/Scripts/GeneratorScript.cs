using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratorScript : MonoBehaviour {

	public GameObject spawner;
	public bool stopSpawning = false;
	public float spawnTime;
	public float spawnDelay;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnObject", spawnTime, spawnDelay);
	}
	
	// Update is called once per frame
	public void SpawnObject(){
		Instantiate (spawner, transform.position, transform.rotation);
		if (stopSpawning) {
			CancelInvoke ("SpawnObject");
		}

	}
		
}
