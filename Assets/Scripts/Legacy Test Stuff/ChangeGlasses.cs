using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChangeGlasses : MonoBehaviour
{
    [SerializeField]
    string key;

    [SerializeField]
    UnityEvent callEvent;

    void Start()
    {
        Debug.Log(Camera.main.cullingMask);
    }
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            callEvent.Invoke();
        }
    }
}
