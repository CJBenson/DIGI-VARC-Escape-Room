using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanopyOpen : MonoBehaviour
{
    [SerializeField]
    private CenterMechanic centerMechanic;

    // Update is called once per frame
    void Update()
    {
        SkinnedMeshRenderer skinnedMeshRenderer = GetComponent<SkinnedMeshRenderer>();
        float blendWeight = 100 - (centerMechanic.GetYInterp() * 100);
        skinnedMeshRenderer.SetBlendShapeWeight(0, blendWeight);
    }
}
