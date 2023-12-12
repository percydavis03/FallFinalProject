using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayStop : MonoBehaviour
{
    public AudioSource audioSource;

    void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
    }

    void OnTriggerExit(Collider other)
    {
        audioSource.Stop();
    }
}
