using UnityEngine;


[CreateAssetMenu]
public class PrefabData : ScriptableObject 
//Changed inheritance to ScriptableObject, in place of MonoBehaviour. 
{
    public GameObject Prefab;
    public Sprite SpriteImage;
    //Cannot name Sprite sprite, because it is a reserved data type.
    public Color SpriteColor;

    public void OnConfigure()
    //Does not return a value.
    {
        var newPrefab = Instantiate(Prefab);
        //What is it doing? What should its name be?
        var newSprite = newPrefab.GetComponent<SpriteRenderer>();
        //GameObject does not come with SpriteRendered, so get the component.
        newSprite.sprite = SpriteImage;
        newSprite.color = SpriteColor;
    }

}
