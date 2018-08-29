using UnityEngine;
using UnityEngine.Events;

public class NewEvent : MonoBehaviour
{
	public UnityEvent MyEvent;
	//Unity Events are the same as the built in Unity Events "OnConfigure ()" on UI buttons.

	private void OnMouseDown()
	{
		MyEvent.Invoke();
		//Invoke is a method that is part of the Event.
		//Will allow you to call any object, so long as it has a function.
	}
}
