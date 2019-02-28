using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueGoalScript : MonoBehaviour
{
	DualGoalScript parent;
	public float timeNeeded;

    // Start is called before the first frame update
    void Start()
    {
		parent = GetComponentInParent<DualGoalScript>();
    }
		

	void OnTriggerStay(Collider col)
	{
		//Debug.Log("IN");
		if (col.gameObject.tag == "Blue") {
			timeNeeded -= Time.deltaTime;
			if (timeNeeded <= 0f) {
				parent.player2 = true;
			}
		}
	}

	void OnTriggerExit (Collider col) {

		//Debug.Log("OUT");
		if (col.gameObject.tag == "Blue") {
			timeNeeded -= Time.deltaTime;
			if (timeNeeded <= 0f) {
				parent.player2 = false;
			}
		}
	}
}
