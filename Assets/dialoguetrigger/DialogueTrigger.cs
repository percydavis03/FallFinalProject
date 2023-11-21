using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DialogueTrigger : MonoBehaviour
{
    [Header("Visual Cue")]
    [SerializeField] private GameObject VisalCue;

    [Header("Ink JSON")]
    [SerializeField] private TextAsset inkJSON;

    private bool playerInRange;

    private void Awake()
    {
        playerInRange = false;
        VisalCue.SetActive(false);
    }

    private void Update()
    {
        if (!playerInRange)
        {
            VisalCue?.SetActive(true);
           // if (StoryManager.GetInstance().GetInteractPressed())
            {
                Debug.Log(inkJSON.text);
            }
        }
        else
        {
            VisalCue?.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void onTriggerExit(Collider collider)
    {
        if (collider.gameObject.tag == "player")
        {
            playerInRange = false;
        }
    }
}
