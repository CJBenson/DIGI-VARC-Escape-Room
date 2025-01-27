using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CenterMechanic : MonoBehaviour
{

    [SerializeField]
    private float localYMin, localYMax;

    private float localYInterpolationValue;

    // Update is called once per frame
    void Update()
    {
        Vector3 localPos = transform.localPosition;
        localPos.x = 0;
        localPos.z = 0;
        localPos.y = Mathf.Clamp(localPos.y, localYMin, localYMax);
        localYInterpolationValue = (localPos.y - localYMin) / (localYMax - localYMin);

        Vector3 localRot = transform.localEulerAngles;
        localRot.x = 0;
        localRot.z = 0;
        localRot.y = 0;

        transform.localPosition = localPos;
        transform.localEulerAngles = localRot;
    }

    public float GetYInterp()
    {
        return localYInterpolationValue;
    }
    public void Kinematize(bool onState)
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.isKinematic = onState;
    }
}
