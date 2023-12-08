using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstChoiceDialogue : MonoBehaviour
{
    public GameObject dragonDialogue;
    public GameObject shimmerDialogue;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DragonBreath"))
        {
            dragonDialogue.SetActive(true);
        }
        if (other.CompareTag("Shimmerleaf"))
        {
            shimmerDialogue.SetActive(true);    
        }

    }




}
