using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	private float splashScreenLoadTime=2.5f;

	void Start() {
		if(SceneManager.GetActiveScene().buildIndex == 0) {
			Invoke ("LoadNextLevel", splashScreenLoadTime);
		}
	}

	public void LoadLevel(string name) {
		SceneManager.LoadScene (name);
	}

	public void QuitRequest() {
		Debug.Log ("Game quit requested");
		Application.Quit();
	}

	public void LoadNextLevel() {
		SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex + 1);
	}
}
