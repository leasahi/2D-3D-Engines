using UnityEngine;
using UnityEngine.Events;

public class DanceParty : MonoBehaviour
{
    public UnityEvent OnPlayerInRange;
    public UnityEvent OnPlayerOutOfRange;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        OnPlayerInRange.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        if (!other.CompareTag("Player"))
        {
            return;
        }
        OnPlayerOutOfRange.Invoke();
    }
}
