using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedCamMovement : MonoBehaviour
{
    private CharacterController controller;
    public float speed = 6f;
    public float turnSpeed = 180f;

     void Start()
    {

        controller = GetComponent<CharacterController>();
    }

    void Update()
    {

        Vector3 movDir;

        transform.Rotate(0, Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime, 0);
        movDir = transform.forward * Input.GetAxis("Vertical") * speed;
        // moves the character in horizontal direction
        controller.Move(movDir * Time.deltaTime - Vector3.up * 0.1f);
    }
}
