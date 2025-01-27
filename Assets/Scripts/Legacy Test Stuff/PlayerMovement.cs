using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // this script comes from a brackeys vid about first person char controllers
    public CharacterController controller;

    public float speed = 12f;

    // Update is called once per frame
    void Update()
    {
        // represents the ways a char can move as x and y (think of it as topdown)
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);
    }
}
