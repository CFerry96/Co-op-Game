using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaloonScript : MonoBehaviour
{
	Animation anim;
	AudioSource audio;
	BalloonManager manager;

    // Start is called before the first frame update
    void Start()
    {
		manager = GameObject.Find ("GameManager").GetComponent<BalloonManager>();
		anim = GetComponent<Animation> ();
		audio = GameObject.Find ("PoppingSounds").GetComponent<AudioSource>();
    }
		

	void OnCollisionEnter (Collision col) {

		if (col.gameObject.tag == "Ground") {

			anim.Play();
			GetComponent<SphereCollider>().enabled = false;
		}
	}

	public void DestroyThisBaloon() {
		audio.Play();
		manager.CountBalloons();
		Destroy(this.gameObject);
	}
}
