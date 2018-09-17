using System.Runtime.Serialization.Formatters;
using UnityEngine;

[CreateAssetMenu (fileName = "FloatBool")]
public class FloatBool : FloatInput 
{

     public override float Value
    {
         get
         {

             if (Input.GetButton(InputType))
             {
                return value;   
             }
                 return 0;
             
         }
    }
}
