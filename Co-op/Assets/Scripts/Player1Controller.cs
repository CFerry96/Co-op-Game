using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Controller : MonoBehaviour
{
    private CharacterController controller;
    

    private float verticalVelocity;
    private float gravity = 14.0f;
    private float jumpForce = 30.0f;

    public Animator anim;

    

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }


    private void Update()
    {
        if(controller.isGrounded)
        {
            verticalVelocity = -gravity * Time.deltaTime;
            if(Input.GetKeyDown(KeyCode.W))
            {
                verticalVelocity = jumpForce;
                anim.SetBool("jump", true);
            }
        }
        else
        {
            verticalVelocity -= gravity * 4 * Time.deltaTime;
        }

        Vector3 moveVector = Vector3.zero;
        moveVector.z = Input.GetAxis("Keys") * 20.0f;
        moveVector.y = verticalVelocity;
        moveVector.x = 0;
        controller.Move(moveVector * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        anim.SetBool("jump", false);
    }
}
