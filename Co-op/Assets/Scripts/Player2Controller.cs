using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Controller : MonoBehaviour
{ 
    private CharacterController controller;
    


    private float verticalVelocity;
    private float gravity = 14.0f;
    private float jumpForce = 30.0f;



    private void Start()
        {
             controller = GetComponent<CharacterController>();
        }


        private void Update()
        {
            if (controller.isGrounded)
            {
                verticalVelocity = -gravity * Time.deltaTime;
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    verticalVelocity = jumpForce;
                }
            }
            else
            {
                verticalVelocity -= gravity * 4 * Time.deltaTime;
            }

            Vector3 moveVector = new Vector3(0, verticalVelocity, 0);
            moveVector.z = Input.GetAxis("Arrows") * 20;
            controller.Move(moveVector * Time.deltaTime);


    }






    #region basic
    /*public GameObject player1, player2;
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
    }*/
    #endregion
}