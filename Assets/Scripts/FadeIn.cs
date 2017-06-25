using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FadeIn : MonoBehaviour {

	public float fadeInTime;
	private CanvasGroup canvasGroup;

	void Start () {
		canvasGroup = GetComponent<CanvasGroup> ();
		canvasGroup.alpha = 0;
		InvokeRepeating ("changeAlpha", 0.000001f, 0.01f);
	}

	void Update() {
		if(canvasGroup.alpha >= 1) {
			CancelInvoke ();
		}
	}

	void changeAlpha() {
		float changeAlpha = Time.deltaTime / fadeInTime;
		canvasGroup.alpha += changeAlpha;
	}
}
