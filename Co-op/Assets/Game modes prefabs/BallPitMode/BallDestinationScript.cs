using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallDestinationScript : MonoBehaviour
{
	public int currentScore = 0;
	public int scoreNeededToWin;
	public AudioSource scoreAPoint;
	public AudioSource winTheGame;
	public float loadTime;
	bool wonTheGame;
	TextMesh currentScoreText;

    // Start is called before the first frame update
    void Start()
    {
		currentScoreText = GameObject.Find("currentScoreText").GetComponent<TextMesh>();

		wonTheGame = false;
    }

    // Update is called once per frame
    void Update()
    {
		currentScoreText.text = "Current Score: " + currentScore.ToString();

		if (currentScore >= scoreNeededToWin && wonTheGame == false) {

			Invoke ("LoadMenu", loadTime);
			//winTheGame.Play();
			wonTheGame = true;
		}
    }

	public void Addpoint(){

		currentScore++;
		//scoreAPoint.Play();
		Debug.Log("Scored!!");
	}

	void LoadMenu () {

		Application.LoadLevel(0);
	}
}
