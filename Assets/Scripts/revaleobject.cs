using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revaleobject : MonoBehaviour
{
    public GameObject itemrenderer;
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            if (!itemrenderer.activeInHierarchy)
            {
                itemrenderer.SetActive(true);
            }
            else
            {
                itemrenderer.SetActive(false);
            }
        }
    }
}
