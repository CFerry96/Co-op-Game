using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowWheelScript : MonoBehaviour
{
	public GameObject wheel;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		Vector3 wheelPos = new Vector3(wheel.transform.position.x, wheel.transform.position.y, 23.5f);
		transform.position = Vector3.Lerp (transform.position, wheelPos, 1f);
    }
}
