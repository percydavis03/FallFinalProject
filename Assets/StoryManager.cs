using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;
public class StoryManager : MonoBehaviour
{
    public TextAsset storyJson;
    public Text leftText, rightText;
    public Button[] optionButton;
    public Text[] optionButtonLabels;
    public Animator leftAnimator, rightAnimator;

    Story ourStory;

    // Start is called before the first frame update
    void Start()
    {
        ourStory = new Story(storyJson.text);
        AdvanceStory();
    }

    // Update is called once per frame
    void Update()
    {
      
        string[] options = new string[2];

        if (ourStory.canContinue)
        {
            options[0] = "Continue";
        }
        else
        {
            for (int i = 0; i < ourStory.currentChoices.Count; i++)
            {
                options[i] = ourStory.currentChoices[i].text;
            }


        }



        SetupOptions(options);
    }

    void SetupOptions(string[] options)
    {
        for (int i = 0; i < 2; i++)
        {
            if (options[i] == null)
            {
                optionButton[i].gameObject.SetActive(false);
            }
            else
            {
                optionButton[i].gameObject.SetActive(true);
                optionButtonLabels[i].text = options[i];
            }
        }
    }

    public void onOptionClicked(int index)
    {
        leftText.text = "";
        rightText.text = "";

        if (ourStory.canContinue)
        {
            AdvanceStory();
        }
        else
        {
            ourStory.ChooseChoiceIndex(index);
            AdvanceStory();
        }
       
    }


    void AdvanceStory()
    {
        
        
            string text = ourStory.Continue();
            Animator currentAnimator = null;
            foreach (string tag in ourStory.currentTags)
            {
                bool noTag = false;

                if (tag == "left")
                {
                    leftText.text += text;
                    noTag = true;
                    currentAnimator = leftAnimator;
                }

                if (tag == "right")
                {
                    rightText.text += text;
                    noTag = true;
                    currentAnimator = rightAnimator;
                }

                if (tag.StartsWith("sound;"))
                {
                    string[] parts = tag.Split(';');
                    string soundName = parts[1];

                    SoundManager.instance.PlaySound(soundName);
                    noTag = true;

                }

                if (tag.StartsWith("image;"))
                {
                    string[] parts = tag.Split(';');
                    string imagename = parts[1];

                    ImageManager.instance.showImage(imagename);
                    noTag = true;

                }
                 if (tag.StartsWith("anime;"))
                 {
                    string[] parts = tag.Split(';');
                    string animeName = parts[1];

                    if (currentAnimator != null)
                    {
                        currentAnimator.SetTrigger(animeName);
                    }
                    else
                    {
                        Debug.LogError("Anime tag found but could not do it without a character!");
                    }

                    noTag = true;
                 }


                if (!noTag)
                {
                    Debug.LogError($"Couldn't interpret tag!");
                }

            }

        
    }
}
