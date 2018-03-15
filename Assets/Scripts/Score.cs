using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public static Score instance;

	public Text scoreText;
	public Text highScoreText;

	public int score;
	public int highScore;

	public bool isIncreasing;

    public void Start()
    {
		if(PlayerPrefs.GetInt(key:"highScore")!= null)
            highScore = PlayerPrefs.GetInt(key:"highScore");
 
    }
	void Awake(){
		MakeInstance();
	}
	void MakeInstance(){
		if(instance == null){
			instance = this;
		}
	}
	public void IncrementScore(){
		if(isIncreasing){
			score++;


			if (score > highScore){
				highScore = score;

			}
			scoreText.text = "Score: " + score;
			highScoreText.text = "High Score: " + highScore;

			PlayerPrefs.SetInt ("highScore", highScore);
		}

	}

	public int GetScore(){
		return this.score;
	}
			

} //ScoreManager