using UnityEngine;

[CreateAssetMenu(fileName = "FloatInput")]
public class FloatInput : FloatData {
//This is a FloatData that is also a ScriptableObject. Contains both Inheritances.
//Can be referenced in a FloatData slot.
    
    public string InputType;
    
    public override float Value
    {
        get {return Input.GetAxis(InputType)*value;}
    }
    
}
