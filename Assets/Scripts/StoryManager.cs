using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;
using System;
using StarterAssets;
using UnityEngine.InputSystem.Android;

public class StoryManager : MonoBehaviour
{
    public TextAsset storyJson;
    //public Text leftText;
    public Text rightText;
    public OptionUI[] optionUIs;
    public Animator rightAnimator;
    //public Animator leftAnimator;
    public Image rightImage;
    public Image leftImage;
    public GameObject DialogBox;
    Story ourStory;
    int currentOption = 0;


    public void ResetStory()
    {
        if (ourStory != null)
        {
            ourStory.ResetState();
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        ourStory = new Story(storyJson.text);
    }

    // Update is called once per frame
    void Update()
    {
        bool canContinue = ourStory.canContinue;
        bool hasChoices = ourStory.currentChoices.Count > 0;
        bool storyOver = !canContinue && !hasChoices && rightText.text == "";
        string[] options = new string[3];

        if (canContinue)
        {
            AdvanceStory();
            SetupOptions(options);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PickOption(currentOption);
        }
        else if (hasChoices)
        {
            for (int i = 0; i < ourStory.currentChoices.Count; i++)
            {
                options[i] = ourStory.currentChoices[i].text;
            }
            if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
            {
                currentOption++;
                if (currentOption >= ourStory.currentChoices.Count)
                {
                    currentOption = 0;
                }
            }

            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
            {
                currentOption--;
                if (currentOption < 0)
                {
                    currentOption = ourStory.currentChoices.Count - 1;
                }
            }
            SetupOptions(options);
        }

        else if (storyOver)
        {
            DialogBox.SetActive(false);
            ourStory.ResetState();
            Debug.Log("Dialogue has finally stop");
        }

    }

    void SetupOptions(string[] options)
    {
        for (int i = 0; i < 3; i++)
        {
            if (options[i] == null)
            {
                optionUIs[i].SetVisible(false);
            }
            else
            {
                optionUIs[i].SetVisible(true);
                optionUIs[i].SetOptionText(options[i]);
                optionUIs[i].SetSelected(i == currentOption);
            }
        }
    }


    public void PickOption(int index)
    {

        rightText.text = "";

        if (ourStory.canContinue)
        {
            AdvanceStory();

        }

        else if (ourStory.currentChoices.Count > 0)
        {
            print(ourStory.currentChoices.Count);
            print("we are in print options");
            ourStory.ChooseChoiceIndex(index);
        }

        currentOption = 0;
    }

    void AdvanceStory()
    {
        Animator currentAnimator = null;
        rightText.text = ourStory.Continue();

        /*if (ourStory.currentTags.Contains("you"))
        {
            //leftText.text += text;
            //currentAnimator = leftAnimator;
        }

        if (ourStory.currentTags.Contains("them"))
        {
            //rightText.text += text;
            //currentAnimator = rightAnimator;
        }*/

        foreach (string tag in ourStory.currentTags)
        {

            bool didSomething = false;


            if (tag.StartsWith("sound;"))
            {
                string[] parts = tag.Split(';');

                string soundName = parts[1];
                Debug.Log("music");
                SoundManager.instance.PlaySound(soundName);
                didSomething = true;
            }

            if (tag.StartsWith("anim;"))
            {
                string[] parts = tag.Split(';');
                string animName = parts[1];

                if (currentAnimator != null)
                {
                    currentAnimator.SetTrigger(animName);
                }
                else
                {
                    Debug.LogError("anim tag found but without a character to use!");
                }
                didSomething = true;

            }
            if (!didSomething)
            {
                Debug.LogError($"Couldn't intgerpret tag {tag}!");
            }
        }
    }

}
