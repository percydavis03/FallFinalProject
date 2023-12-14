using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revaleobject : MonoBehaviour
{
    public GameObject itemrenderer;
    public GameObject hagstone;
    public bool gotHagstone;
    
    void Start()
    {
        gotHagstone = false; 

    }

    private void OnTriggerEnter(Collider other)
    {
        gotHagstone = true;
    }
    void Update()
    {
        if (gotHagstone == true) 
        {
            if (Input.GetKeyDown(KeyCode.C))
            {
                if (!itemrenderer.activeInHierarchy)
                {
                    itemrenderer.SetActive(true);
                    hagstone.SetActive(true);
                }
                else
                {
                    itemrenderer.SetActive(false);
                    hagstone.SetActive(false);
                }
            }
        }
    }
}
