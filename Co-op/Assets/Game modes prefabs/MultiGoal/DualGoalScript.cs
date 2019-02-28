using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualGoalScript : MonoBehaviour
{
    public bool player1;
    public bool player2;
	public AudioSource audio;
	public float loadTime;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (player1 && player2 == true) {

			audio.Play();
			Invoke ("LoadMenu", loadTime);
		}
    }

	void LoadMenu () {

		Application.LoadLevel(0);
	}
}
