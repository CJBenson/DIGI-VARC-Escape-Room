using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorSplit : MonoBehaviour
{
    [SerializeField]
    private GameObject[] pieces;
    [SerializeField]
    private Transform[] locations;
    [SerializeField]
    private GameObject mirror;
    [SerializeField]
    float breakingVelocity;
    public void Split()
    {
        Destroy(mirror);

        for (int i = 0; i < pieces.Length; i++)
        {
            Transform thisTrans = locations[i];
            Instantiate(pieces[i], thisTrans.position, thisTrans.rotation);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody>() != null && collision.gameObject.GetComponent<Rigidbody>().velocity.magnitude > breakingVelocity)
        {
            Split();
            Debug.Log(collision.gameObject);
        }
    }
}
