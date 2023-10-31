using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public AudioSource audioSource;

    public AudioLibrary audioLibrary;
    // Start is called before the first frame update



    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlaySound(string fileName)
    {
        foreach (AudioClip clip in audioLibrary.AudioClips)
        {
            if (clip.name == fileName)
            {
                if (audioSource == null) 
                {
                    Debug.LogError("AudioSorce was null!");

                        
                }

            if (clip == null)
                {
                    
                    Debug.LogError("audio play clip");

                }
                audioSource.PlayOneShot(clip);
                return;
            }
        }

        Debug.LogError($"Tried to play sound {fileName} but couldn't find it!");
    }
}
