using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressButton : MonoBehaviour
{
    // this script should be able to go on just about anything, but camera or player empty would be best

    // Update is called once per frame
    void Update()
    {
        // if you press LMouse, raycast goes from camera's transform straight out
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 startingPoint = Camera.main.transform.position;
            Vector3 direction = Camera.main.transform.forward;

            float length = 1000;

            RaycastHit hitInfo;

            bool hit = Physics.Raycast(startingPoint, direction, out hitInfo, length);

            if (hit == true)
            {
                GameObject objHit = hitInfo.collider.gameObject;

                // if the object the raycast hits is a button, it gets the press script on the button and presses it
                // there's probably a better way to do this than a script on both the player and the button
                if(objHit.tag == "Interactable")
                {
                    Interaction interaction = objHit.GetComponent<Interaction>();
                    interaction.Call();
                } 
                
                // if the object is not a button and is in fact grabbable, it will get the grabbable script and grab it
                // grabbable is a layer and button is a tag, mostly for specificity
                else if(objHit.layer == 8)
                {
                    GrabbableObject go = objHit.GetComponent<GrabbableObject>();
                    Rigidbody body = objHit.GetComponent<Rigidbody>();
                    go.grabbed = !go.grabbed;
                    body.isKinematic = false;
                }
            }
        }
    }
}
