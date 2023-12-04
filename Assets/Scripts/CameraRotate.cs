using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraRotate : MonoBehaviour
{
    public Transform target; // Player or target to rotate around
    public float rotationSpeed = 5f;

    void Update()
    {
        // Rotate the camera around the target when Q key is pressed
        if (Input.GetKey(KeyCode.Q))
        {
            RotateCamera(-rotationSpeed);
        }

        // Rotate the camera around the target when E key is pressed
        if (Input.GetKey(KeyCode.E))
        {
            RotateCamera(rotationSpeed);
        }
    }

    void RotateCamera(float rotationAmount)
    {
        // Calculate the new rotation based on the rotation amount and speed
        transform.RotateAround(target.position, Vector3.up, rotationAmount * Time.deltaTime);
    }
}
