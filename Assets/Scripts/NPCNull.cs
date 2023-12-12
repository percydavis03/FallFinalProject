using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCNull : MonoBehaviour
{

    public GameObject npc;
    public GameObject npc1;


    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            npc.SetActive(false);
            npc1.SetActive(true);
        }
    }


    
}
