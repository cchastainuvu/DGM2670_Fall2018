using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour
{

    //public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;

    public FloatData MoveX, MoveY, MoveZ;
    //FloatData can be an input (see FloatInput) or just a simple value.
    
    private CharacterController controller;
    private Vector3 moveDirection = Vector3.zero;
    //A temporary variable to define where a character will be in X,Y,Z.
    

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        
    }

    void Update()
    {
        if (controller.isGrounded)
        {
            moveDirection.Set(MoveX.Value, MoveY.Value, MoveZ.Value);
            moveDirection = transform.TransformDirection(moveDirection);
            //*moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
            
        }

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

    }
}