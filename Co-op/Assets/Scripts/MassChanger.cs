﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassChanger : MonoBehaviour
{

    public Rigidbody rb1;
    public Transform p1;


    public Rigidbody rb2;
    public Transform p2;

	AudioSource audio;
    
    // Start is called before the first frame update
    void Start()
    {
		audio = GetComponent<AudioSource>();
    }
    public void massChanger()
    {
        if (rb1.mass == 3 && Input.GetKeyDown("s"))
        {
            rb1.mass -= 1;
			p1.GetComponent<Animation>().Play("ScaleDown (3-2)");
            rb2.mass += 1;
			p2.GetComponent<Animation>().Play("ScaleUp (1-2)");
			audio.Play();

        }
        else if (rb1.mass == 2 && Input.GetKeyDown("s"))
        {
            rb1.mass -= 1;
			p1.GetComponent<Animation>().Play("ScaleDown (2-1)");
            rb2.mass += 1;
			p2.GetComponent<Animation>().Play("ScaleUp (2-3)");
			audio.Play();
        }
        else if (rb1.mass == 1 && Input.GetKeyDown("s"))
        {
            
        }

        if(rb2.mass == 3 && Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb1.mass += 1;
			p1.GetComponent<Animation>().Play("ScaleUp (1-2)");
            rb2.mass -= 1;
			p2.GetComponent<Animation>().Play("ScaleDown (3-2)");
			audio.Play();
        }
        else if(rb2.mass == 2 && Input.GetKeyDown(KeyCode.DownArrow))
        {
            rb1.mass += 1;
			p1.GetComponent<Animation>().Play("ScaleUp (2-3)");
            rb2.mass -= 1;
			p2.GetComponent<Animation>().Play("ScaleDown (2-1)");
			audio.Play();

        }
        else if(rb2.mass == 1 && Input.GetKeyDown(KeyCode.DownArrow))
        {

        }

    }

//    public void scaleChanger()
//    {
//        if(rb1.mass == 1 && rb2.mass == 3)
//        {
//            p1.localScale = new Vector3(1, 1, 1);
//            p2.localScale = new Vector3(3, 3, 3);
//        }
//        else if(rb1.mass == 2 && rb2.mass == 2)
//        {
//            p1.localScale = new Vector3(2, 2, 2);
//            p2.localScale = new Vector3(2, 2, 2);
//        }
//        else if (rb1.mass == 3 && rb2.mass == 1)
//        {
//            p1.localScale = new Vector3(3, 3, 3);
//            p2.localScale = new Vector3(1, 1 ,1);
//        }
//    }

    // Update is called once per frame
    void Update()
    {
        massChanger();
       // scaleChanger();
    }
}
