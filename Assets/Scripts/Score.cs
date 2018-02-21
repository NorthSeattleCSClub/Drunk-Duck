using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text scoreText;
	public Text highScoreText;

	public float scoreCount;
	public float highScoreCount;

	public float pointsPerSecond;
	public bool scoreIncreasing;

	public void Start(){
		if (PlayerPrefs.GetFloat ("highScore") != null) {
			highScoreCount = PlayerPrefs.GetFloat ("highScore");
		}
	}
	public void Update () {
	if(scoreIncreasing){
		scoreCount += pointsPerSecond * Time.deltaTime;
	}

		if(scoreCount > highScoreCount){
			highScoreCount = scoreCount;
			PlayerPrefs.SetFloat ("highScore", highScoreCount);
		}
		scoreText.text = "Score: " + (int)scoreCount;
		highScoreText.text = "High Score: " + (int)highScoreCount;
}

}