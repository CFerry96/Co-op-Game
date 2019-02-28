using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    void OnTriggerEnter(Collider col) {

		Debug.Log("Entered");
		if (col.gameObject.tag == this.gameObject.tag) {
			Debug.Log("Entered green");
			col.GetComponentInParent<BallDestinationScript>().Addpoint();
			Destroy(this.gameObject);
		}
    }
}
