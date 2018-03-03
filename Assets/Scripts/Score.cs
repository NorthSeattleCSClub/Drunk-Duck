using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static Score instance;

	public Text scoreText;
	public Text highScoreText;

	private int score;
	private int highScore;

	void Awake() {
		MakeInstance ();
	}

	void MakeInstance() {
		if (instance == null)
			instance = this;
	}

	public void IncrementScore() {
		score++;
		scoreText.text = "Score: " + score;

		if (score > highScore) {
			highScore = score;
			highScoreText.text = "High Score: " + highScore;
		}
	}

	public int GetScore() {
		return this.score;

	}


} //ScoreManager