using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{
    public GameObject cam1;
    public GameObject cam2;
    void Update()
    {
        if (Input.GetKeyDown("1key"))
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
        }

        if (Input.GetKeyDown("1key"))
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
    }
}
