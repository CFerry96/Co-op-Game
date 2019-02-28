using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WheelScript : MonoBehaviour
{

	float currentSpeed;
	public float highestSpeed;
	public Text Text;
	Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
		rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		currentSpeed = rb.velocity.magnitude;
	
		if (currentSpeed > highestSpeed) {

			highestSpeed = currentSpeed;
			Text.text = "Current HighSpeed:                    " + highestSpeed.ToString("F3");
		}
    }
}
