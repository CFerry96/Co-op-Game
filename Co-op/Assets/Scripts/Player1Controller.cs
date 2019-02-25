using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    private CharacterController controller;
    

    private float verticalVelocity;
    private float gravity = 14.0f;
    private float jumpForce = 20.0f;
    private float speed = 10.0f;

    

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }


    private void Update()
    {
        if(controller.isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime;
            if(Input.GetKeyDown(KeyCode.Space))
            {
                verticalVelocity = jumpForce;
            }
        }
        else
        {
            verticalVelocity -= gravity * 4 * Time.deltaTime;
        }

        Vector3 moveVector = new Vector3(0, verticalVelocity, 0);
        moveVector.z = Input.GetAxis("Horizontal") * 20.0f;
        //moveVector.y = verticalVelocity;
        controller.Move(moveVector * Time.deltaTime);

        /*if (Input.GetKeyDown(KeyCode.A))
        {
            this.transform.position += new Vector3(0, 0, -speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            this.transform.position += new Vector3(0, 0, speed * Time.deltaTime);
        }*/

    }
}
