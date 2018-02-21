using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRandom : MonoBehaviour {

	public GameObject spawner;
	public bool stopSpawning = false;
	public float minSpawnTime;
	public float maxSpawnTime;
	public float minSpawnDelay;
	public float maxSpawnDelay;
	public float minX;
	public float maxX;
	public float minY;
	public float maxY;

	// Use this for initialization
	void Start () {
		float spawnTime = Random.Range (minSpawnTime, maxSpawnTime);
		float spawnDelay = Random.Range (minSpawnDelay, maxSpawnDelay);
		InvokeRepeating ("SpawnObject", spawnTime, spawnDelay);
	}

	// Update is called once per frame
	public void SpawnObject(){
		Instantiate (spawner, transform.position, transform.rotation);
		if (stopSpawning) {
			CancelInvoke ("SpawnObject");
		}
		float x = Random.Range(minX,maxX);
		float y = Random.Range(minY,maxY);

		Instantiate(spawner, new Vector3(x,y,0), Quaternion.identity);
	}

}
