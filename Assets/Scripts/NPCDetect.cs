using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NPCDetect : MonoBehaviour
{
    bool player_detection = false;

    void Update()
    {
        if (player_detection == true)
        {
            if (Keyboard.current.fKey.isPressed)
            {
                Debug.Log("Dialogue start");
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("DialogueInteractPopUp");
        if (other.name == "Player")
        {
            player_detection = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        player_detection = false;
    }

}
