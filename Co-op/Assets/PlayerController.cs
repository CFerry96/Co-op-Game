using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject player1, player2;
    public Rigidbody rb1, rb2;
    private float speed;
    public float jumpForce = 100;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void p1Movement()
    {
        if (Input.GetKey("a"))  //Left
        {
            //player1.transform.position += new Vector3(0, 0, -speed * Time.deltaTime);
            rb1.AddForce(0, 0, -speed);
        }

        if (Input.GetKey("d"))  //Right
        {
            rb1.AddForce(0, 0, speed);
        }

        if (Input.GetKeyDown("w"))  //Jump
        {
            rb1.AddForce(0, jumpForce, 0);
        }

    }

    void p2Movement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))  //Left
        {
            rb2.AddForce(0, 0, -speed);
        }

        if (Input.GetKey(KeyCode.RightArrow))  //Right
        {
            rb2.AddForce(0, 0, speed);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))  //Jump
        {
            rb2.AddForce(0, jumpForce, 0);
        }

    }

    // Update is called once per frame
    void Update()
    {
        speed = 50;
        p1Movement();
        p2Movement();
    }
}
