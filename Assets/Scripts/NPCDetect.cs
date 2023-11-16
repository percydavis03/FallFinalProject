using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NPCDetect : MonoBehaviour
{
    public bool playerDetection;
    public GameObject DialogBox;

    void Start()
    {
        playerDetection = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("DialogueInteractPopUp");
        if (other.tag == "Player")
        {
            playerDetection = true;
            print("we touch a player");
        }
    }

    void Update()
    {
        if (playerDetection && Input.GetKeyDown(KeyCode.F))
        {
            DialogBox.SetActive(true);
            print("Dialogue Started!");
        }
       
       
    }

    private void OnTriggerExit(Collider other)
    {
        playerDetection = false;
        DialogBox.SetActive(false);
    }

}
