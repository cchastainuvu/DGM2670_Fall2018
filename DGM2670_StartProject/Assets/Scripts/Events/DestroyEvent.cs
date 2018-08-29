
using UnityEngine;
using UnityEngine.Events;

public class DestroyEvent : MonoBehaviour
{

	public UnityEvent Event;

	private void OnDestroy()
	{
		Event.Invoke();
	}
}
