using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public string playGameLevel;

	public void PlayGame(){
		SceneManager.LoadScene(playGameLevel);
	}

	public void QuitGame(){
		Application.Quit();
	}

}
