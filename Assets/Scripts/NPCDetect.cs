using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NPCDetect : MonoBehaviour
{
    public bool playerDetection;

    void Start()
    {
        playerDetection = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("DialogueInteractPopUp");
        if (other.name == "Player")
        {
            playerDetection = true;
        }
    }

    void Update()
    {
        if (playerDetection == true)
        {
            if (Keyboard.current.fKey.isPressed)
            {
                Debug.Log("Dialogue start");
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        playerDetection = false;
    }

}
