using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour 
{
    //CharacterController is a Collider, and can work independently of a Rigidbody.
    
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;

    public FloatData MoveX, MoveY, MoveZ;
    //All three are FloatData so they can be typed on the same line.
    
    private Vector3 moveDirection = Vector3.zero;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }
    //Line will only be run once instead of multiple instances of CharacterController.
    
    void Update() {

       
        if (controller.isGrounded) {
            //isGrounded is a public bool built into the Character Controller.
            //moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            //Vector3 is being continually replaced when keyword "new" is used.
            //Anything that is not referenced is still there. Garbage is being made by Update().
            //Making a new object isn't problematic, but it is bad if it's making 5,000+ on Update.
            moveDirection.Set(MoveX.Value,MoveY.Value,MoveZ.Value);
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
            
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }
}
