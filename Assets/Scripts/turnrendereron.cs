using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turnrendereron : MonoBehaviour
{
    private Renderer itemrenderer;
    // Start is called before the first frame update
    void Start()
    {
        itemrenderer = GetComponent<Renderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (!itemrenderer.enabled)
            {
                itemrenderer.enabled = true;
            }
            else
            {
                itemrenderer.enabled = false;
            }
        }
    }
}
