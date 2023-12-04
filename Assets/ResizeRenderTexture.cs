using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResizeRenderTexture : MonoBehaviour
{
    void Awake()
    {
            Camera camera = GetComponent<Camera>();
        camera.targetTexture.width = Camera.main.pixelWidth;
        camera.targetTexture.height = Camera.main.pixelHeight;
    }

   
}
