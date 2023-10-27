using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    private AudioSource audioSource;

    public AudioLibrary audioLibrary;
    // Start is called before the first frame update


    void Awake()
    {
        if (instance == null)
            instance = this;
    }


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //Debug.LogWarning("Initialized SoundManager with " + (audioSource != null));
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlaySound(string fileName)
    {
        foreach (AudioClip clip in audioLibrary.audioClips)
        {
            if (clip.name == fileName)
            {
                if (audioSource == null)
                {
                    Debug.LogError("AudioSorce is null!");

                }

            if(clip == null)
                {

                    Debug.LogError("audio plays clip");
                }

                audioSource.PlayOneShot(clip);
                return;
            }
        }
        Debug.LogError($"Tried to play sounds {fileName} but could not find it");
    }
}
