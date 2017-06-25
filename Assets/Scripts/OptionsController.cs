using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {

	public Slider volumeSlider;
	public Slider difficultySlider;
	public LevelManager levelManager;

	private MusicManager musicManager;

	// Use this for initialization
	void Start () {
		volumeSlider.value = PlayerPrefsManager.GetMasterVolume ();
		difficultySlider.value = PlayerPrefsManager.GetDifficulty ();
		musicManager = GameObject.FindObjectOfType<MusicManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		musicManager.changeVolume (volumeSlider.value);
		
	}

	public void SaveAndExit() {
		PlayerPrefsManager.SetMasterVolume (volumeSlider.value);
		PlayerPrefsManager.SetDifficulty (difficultySlider.value);

		levelManager.LoadLevel ("01a Start");
	}

	public void SetDefaults() {
		volumeSlider.value = 0.80f;
		difficultySlider.value = 2f;
	}
}
