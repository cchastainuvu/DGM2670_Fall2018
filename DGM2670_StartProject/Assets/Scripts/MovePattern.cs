using System.Collections;

using UnityEngine;

[CreateAssetMenu]
public class MovePattern : ScriptableObject
{

    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;

    public FloatData MoveX, MoveY, MoveZ;
    public FloatData RotX, RotY, RotZ;

    private Vector3 moveDirection;
    private Vector3 rotDirection;


    public void Invoke(CharacterController controller, Transform transform)
    {

        //Controller and Transform are red because we need to bring in MonoBehaviour.

        if (controller.isGrounded)
        {

            moveDirection.Set(MoveX.Value, MoveY.Value, MoveZ.Value);

            transform.Rotate(rotDirection);
            rotDirection.Set(RotX.Value, RotY.Value, RotZ.Value);

            moveDirection = transform.TransformDirection(moveDirection);

            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;

        }

    }
}
