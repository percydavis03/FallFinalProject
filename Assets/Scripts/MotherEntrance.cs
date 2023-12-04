using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class MotherEntrance : MonoBehaviour
{
    private bool hasBeenActivated = false;
    public GameObject barrier;


  
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player") && hasBeenActivated)
        {
            Debug.Log("Trigger activated");

            barrier.SetActive(true);
            hasBeenActivated = true;
        }
    }
}
        

