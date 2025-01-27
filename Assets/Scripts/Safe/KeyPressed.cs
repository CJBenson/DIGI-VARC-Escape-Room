using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class KeyPressed : MonoBehaviour
{
    public void PressedKey()
    {
        this.transform.GetComponentInParent<KeyInput>().SendKey();
    }
}
