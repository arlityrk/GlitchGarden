using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MusicManager : MonoBehaviour {
	public AudioClip[] musicArrayChangeOnLevel;
	private AudioSource audioSource;
	private AudioClip newLevelMusic;
	void Awake() {
		DontDestroyOnLoad(gameObject);
		audioSource = GetComponent<AudioSource>();
	}
	private void OnEnable() { SceneManager.sceneLoaded += OnSceneLoaded;}
	private void OnDisable() { SceneManager.sceneLoaded -= OnSceneLoaded;}
	private void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode) {
		newLevelMusic = musicArrayChangeOnLevel[scene.buildIndex];
		if (newLevelMusic && audioSource.clip != newLevelMusic) {
			audioSource.clip = newLevelMusic;
			if (scene.buildIndex != 0) {
				audioSource.loop = true;
			}
			audioSource.Play();
		}
	}

	public void changeVolume(float volume){
		audioSource.volume = volume;	
	}
}