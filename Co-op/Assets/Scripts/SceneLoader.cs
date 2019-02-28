using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneLoader : MonoBehaviour
{
	public float loadWaitTime;
	public AudioSource audio;

	void LoadTutorial() {

		Application.LoadLevel (1);
	}

	void LoadBaloons() {

		Application.LoadLevel (3);
	}

	void LoadBallPit() {

		Application.LoadLevel (2);

	}

	void LoadTandemWheel() {

		Application.LoadLevel (4);

	}

	public void GoToLoadBaloons() {

		audio.Play();
		Invoke("LoadBaloons", loadWaitTime);
	}

	public void GoToLoadBallPit() {

		audio.Play();
		Invoke("LoadBallPit", loadWaitTime);
	}

	public void GoToLoadTutorial() {

		audio.Play();
		Invoke("LoadTutorial", loadWaitTime);
	}

	public void GoToLoadTandemWheel() {

		audio.Play();
		Invoke("LoadTandemWheel", loadWaitTime);
	}
}
