using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeyItsPlatform : MonoBehaviour {

	// Use this for initialization
	public GameObject platformObject;

	public int numberPlatform;
	public float levelWidth = 3f;
	public float minY = .2f;
	public float maxY = 1.5f;

	void Start () {

		Vector3 positionSpawn = new Vector3();

		for (int i = 0	; i != numberPlatform; i++) {
			positionSpawn.y += Random.Range(minY, maxY);
			positionSpawn.x = Random.Range (-levelWidth, levelWidth);
			Instantiate (platformObject, positionSpawn, Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
