using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayStop : MonoBehaviour
{
    public AudioSource audioSource;

    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
    }

    private void OnTriggerExit(Collider other)
    {
        audioSource = null;
    }
}
