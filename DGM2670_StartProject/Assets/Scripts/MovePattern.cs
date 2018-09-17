using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class MovePattern : ScriptableObject
{

//    public FloatData jumpSpeed;
    public FloatData gravity;

    public FloatData MoveX, MoveY, MoveZ;
    public FloatData RotX, RotY, RotZ;

    private Vector3 moveDirection;
    private Vector3 rotDirection;


    public virtual void Invoke(CharacterController controller, Transform transform)
    {
        //Controller and Transform are red because we need to bring in MonoBehaviour.

        if (controller.isGrounded)
        {
            Move(transform);

//            if (Input.GetButton("Jump"))
//                moveDirection.y = jumpSpeed.Value;
        }

            Move(controller);
    }

    protected void Move(CharacterController controller)
    {
        moveDirection.y -= gravity.Value * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }

    protected void Move(Transform transform)
    {
        moveDirection.Set(MoveX.Value, MoveY.Value, MoveZ.Value);
        transform.Rotate(rotDirection);
        rotDirection.Set(RotX.Value, RotY.Value, RotZ.Value);
        moveDirection = transform.TransformDirection(moveDirection);
    }
    
    //Both have the same name, but it is fine because they are different return types. (Method Overloading)
}

