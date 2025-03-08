using UnityEngine;
using UnityEngine.Events;
public class SimpleTriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerEvent;

    private void OnTriggerEnter(Collider other)
    {
        // Trigger the event
        triggerEvent.Invoke();
    }
}
