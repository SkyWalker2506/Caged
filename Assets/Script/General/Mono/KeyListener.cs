using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class KeyListener : MonoBehaviour
{
    [SerializeField] KeyCode keyCode;
    [SerializeField] UnityEvent keyEvent;


    void Update()
    {
        if (Input.GetKeyDown(keyCode))
            keyEvent?.Invoke();
    }
}
