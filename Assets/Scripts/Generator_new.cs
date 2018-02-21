using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generator_new : MonoBehaviour {

	public GameObject spawner;
	public bool stopSpawning = false;
	public float spawnTimeMin;
	public float spawnTimeMax;
	public float spawnDelayMin;
	public float spawnDelayMax;



	// Use this for initialization
	void Start () {
		float spawnTime = Random.Range(spawnTimeMin, spawnTimeMax);
		float spawnDelay = Random.Range(spawnDelayMin, spawnDelayMax);
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
