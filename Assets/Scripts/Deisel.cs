using Ink.Parsed;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Deisel : MonoBehaviour
{
    public AudioSource audioSource;
    public GameObject dialogueButtonText;
    public bool canSpeak = false;   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        canSpeak = true;
        dialogueButtonText.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        canSpeak = false; 
        dialogueButtonText.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (canSpeak == true)
        {
            if (Keyboard.current.fKey.isPressed)
            {
                audioSource.Play();

            }
        }
    }
}
