using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DualGoalChildScript : MonoBehaviour
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
		if (col.gameObject.tag == this.gameObject.tag) {
			timeNeeded -= Time.deltaTime;
			if (timeNeeded <= 0f) {
				if (this.gameObject.tag == "Green") {
					parent.player1 = true;
				} else  {
					parent.player2 = true;
				}
			} 
		}
	}

	void OnTriggerExit (Collider col) {
		
		//Debug.Log("Out");
		if (col.gameObject.tag == this.gameObject.tag) {

			if (this.gameObject.tag == "Green")
				parent.player1 = false;
		} else {

			parent.player2 = false;
		}
	}
}
