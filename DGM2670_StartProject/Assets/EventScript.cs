using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventScript : MonoBehaviour
{

    public UnityEvent MyEvent;

    private void OnMouseDown()
    {
        MyEvent.Invoke();
        //Will run Prefab object on Start. Not dependent. Invoke > Run.
    }

    private void OnTriggerEnter(Collider other)
    {
        MyEvent.Invoke();
    }
}
