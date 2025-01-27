using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GlassesPickup : Interaction
{
    [SerializeField]
    GameObject myButton;

    public override void Call()
    {
        myButton.SetActive(true);
        Destroy(gameObject);
    }
}
