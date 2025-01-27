using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabbableObject : MonoBehaviour
{
    // grabLocation is where the object hovers in front of player when grabbed, not needed in vr
    public GameObject grabLocation;
    public bool grabbed;

    // Start is called before the first frame update
    // obj is obvi not grabbed at the start, for some objects like mirror, they should be kinematic before being grabbed
    void Start()
    {
        grabbed = false;
        Rigidbody body = gameObject.GetComponent<Rigidbody>();
        body.isKinematic = true;
    }

    // Update is called once per frame
    // just keeps the grabbed obj in place
    void Update()
    {
        if (grabbed)
        {
            transform.position = grabLocation.transform.position;
        }
    }


}
