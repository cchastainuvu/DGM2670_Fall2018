using UnityEngine;

[CreateAssetMenu(fileName = "NewFloat", menuName = "FloatData")]
//Could add initials and a forward slash to create submenus.
public class FloatData : ScriptableObject 
//Start() and Update() are not inherited from ScriptableObject, but from MonoBehaviour.

{

    public float value;
    
    public virtual float Value
    {
        get {return value;}
    }
//The above is a Property. It will function the same way but allow more room for work later.
//Properties are public, but not visible. Cannot be changed in the Unity Editor.
    //Capable of modifying data.
    
//Fields ARE accessible and changeable in the Unity Editor.
}
