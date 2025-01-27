using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorCam : MonoBehaviour
{

    // fun script (a little wonky in practice) for making a camera mirror act like a normal mirror
    // uses player transform relative to mirror to change camera angle
    public Transform playerTransform;


    // Update is called once per frame
    void Update()
    {
        // measures the difference in each axis and uses trig to calculate the resulting camera angle
        // I have drawings somewhere about how the trig works, it's reverse tangent stuff
        float zDiff = Mathf.Abs(transform.position.z - playerTransform.position.z);
        float xDiff = -(transform.position.x - playerTransform.position.x);
        float yDiff = -(transform.position.y - playerTransform.position.y);

        float xRotation = -(90 - Mathf.Atan2(zDiff, yDiff) * (180f / Mathf.PI));
        float yRotation = -(90 - Mathf.Atan2(zDiff, xDiff) * (180f / Mathf.PI));

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0f);
    }
}
