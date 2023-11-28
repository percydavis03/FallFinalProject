using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VirtualCamera : MonoBehaviour
{
    
    public void Use()
    {
        Camera mainCamera = Camera.main;

        mainCamera.transform.position = transform.position;
        mainCamera.transform.rotation = transform.rotation;
    }


}
