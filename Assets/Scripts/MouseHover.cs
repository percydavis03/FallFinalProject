using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHover : MonoBehaviour
{
    //When the mouse hovers over the GameObject, it turns to this color (red)
    Color m_MouseOverColor = Color.blue;

    //This stores the GameObject’s original color
    Color m_OriginalColor;

    //Get the GameObject’s mesh renderer to access the GameObject’s material and color
    MeshRenderer m_Renderer;

    void Start()
    {
        //Fetch the mesh renderer component from the GameObject
        m_Renderer = GetComponent<MeshRenderer>();
        //Fetch the original color of the GameObject
        m_OriginalColor = m_Renderer.material.color;
        GetComponent<Renderer>().material.SetFloat("Hover", 0);
    }

    void OnMouseOver()
    {
        GetComponent<Renderer>().material.SetFloat("Hover", 1);
    }

    void OnMouseExit()
    {
        GetComponent<Renderer>().material.SetFloat("Hover", 0);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Renderer>().material.SetFloat("Hover", 1);
        }
        else
        {
            GetComponent<Renderer>().material.SetFloat("Hover", 0);
        }
    }
}
