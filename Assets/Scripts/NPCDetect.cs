using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class NPCDetect : MonoBehaviour
{
    public bool playerDetection;
    public GameObject DialogBox;
    public GameObject ButtonPopup;

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
            ButtonPopup.SetActive(true);
            print("we touch a player");
        }
    }

    void Update()
    {
        if (playerDetection && Input.GetKeyDown(KeyCode.F))
        {
            DialogBox.SetActive(true);
            print("Dialogue Started!");
            ButtonPopup.SetActive(false);
        }


    }

    private void OnTriggerExit(Collider other)
    {
        
            playerDetection = false;
            DialogBox.SetActive(false);
            ButtonPopup.SetActive(false);
            DialogBox.GetComponent<StoryManager>().ResetStory();

    }
}
