using UnityEngine;
using UnityEngine.Events;

public class OnStart : MonoBehaviour
{
    [SerializeField] UnityEvent startEvent;

    void Start()
    {
            startEvent?.Invoke();
    }
}