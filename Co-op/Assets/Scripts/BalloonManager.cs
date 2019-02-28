using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonManager : MonoBehaviour
{
	float timeInGame = 0f;
	public TextMesh timer;
	public GameObject[] balloons;
	AudioSource audio;
	bool gameOver;

    // Start is called before the first frame update
    void Start()
    {
		audio = GetComponent<AudioSource>();
		CountBalloons();
    }

    // Update is called once per frame
    void Update()
    {

		timeInGame += Time.deltaTime;
		timer.text = "Current Record: " + timeInGame.ToString("F1");

		if (balloons.Length < 3 && ! gameOver) {
			audio.Play();
			gameOver = true;
			Invoke ("LoadMenu", 2f);
		}
    }

	public void CountBalloons () {

		balloons = GameObject.FindGameObjectsWithTag ("Baloon");
	}

	void LoadMenu () {

		Application.LoadLevel(0);
	}
}
