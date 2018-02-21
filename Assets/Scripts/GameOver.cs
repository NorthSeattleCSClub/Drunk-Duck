using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {
	public string playAgain;
	public string backToMainMenu;
	public void PlayAgain()
	{
		SceneManager.LoadScene (playAgain);
	}
	public void BackToMainMenu(){
		SceneManager.LoadScene (backToMainMenu);
	}

}
