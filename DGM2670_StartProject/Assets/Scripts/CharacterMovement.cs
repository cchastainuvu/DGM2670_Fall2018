using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(CharacterController))]
public class CharacterMovement : MonoBehaviour

{

    private CharacterController controller;
    public MovePattern Pattern;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Pattern.Invoke(controller, transform);
    }

}



                //OLD CHARACTER CONTROLLER
//{
//
//    //public float speed = 6.0F;
//    public FloatData jumpSpeed;
//
//    public FloatData gravity;
//    public FloatData MoveX, MoveY, MoveZ;
//    public FloatData RotX, RotY, RotZ;
//    //FloatData can be an input (see FloatInput) or just a simple value.
//    
//    private CharacterController controller;
//
//    private Vector3 moveDirection;
//    private Vector3 rotDirection;
//    
//    //Vector3's default at zero automatically.
//    //A temporary variable to define where a character will be in X,Y,Z.
//    
//
//    private void Start()
//    {
//        controller = GetComponent<CharacterController>();
//    }
//
//    void Update()
//    {
//        if (controller.isGrounded)
//        {
//            moveDirection.Set(MoveX.Value, MoveY.Value, MoveZ.Value);
//
//            rotDirection.Set(RotX.Value, RotY.Value, RotZ.Value);
//            transform.Rotate(rotDirection);
//            
//            moveDirection = transform.TransformDirection(moveDirection);
//            //*moveDirection *= speed;
//            if (Input.GetButton("Jump"))
//                moveDirection.y = jumpSpeed.Value;
//            
//        }
//
//        moveDirection.y -= gravity.Value * Time.deltaTime;
//        controller.Move(moveDirection * Time.deltaTime);
//
//    }
//}