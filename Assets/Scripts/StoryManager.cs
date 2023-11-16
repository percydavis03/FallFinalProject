using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Ink.Runtime;

public class StoryManager : MonoBehaviour
{
    public TextAsset storyJson;
    public Text leftText, rightText;
    public OptionUI[] optionUIs;
    //public Animator rightAnimator;
    public Animator leftAnimator;
    public Image rightImage;
    public Image leftImage;
    Story ourStory;
    int currentOption = 0;

    // Start is called before the first frame update
    void Start()
    {
        ourStory = new Story(storyJson.text);
        AdvanceStory();
    }

    // Update is called once per frame
    void Update()
    {
            string[] options = new string[3];

        if (ourStory.canContinue)
        {
            options[0] = "Continue";
        }
        else
        {
          for(int i = 0; i < ourStory.currentChoices.Count; i++)
            {
                options[i] = ourStory.currentChoices[i].text;
            }

        }
          

            SetupOptions(options);
            
        
        
        
        if(Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
        {
            currentOption++;
            if(currentOption >= ourStory.currentChoices.Count)
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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            PickOption(currentOption);
        }


    }

        void SetupOptions(string[] options)
        {
            for (int i = 0; i < 3; i++)
            {
                if (options[i] == null)
                {
                    optionUIs[i].gameObject.SetActive(false);
                }
                else
                {
                  optionUIs[i].SetVisible(true);
                  optionUIs[i].SetOptionText (options[i]);
                optionUIs[i].SetSelected(i == currentOption);  
                }
            }
        }

        public void PickOption(int index)
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

        currentOption = 0;

        }

    void AdvanceStory()
    {
        string text = ourStory.Continue();
        Animator currentAnimator = null;


        if (ourStory.currentTags.Contains("you"))
        {
            leftText.text += text;
            currentAnimator = leftAnimator;
        }

        if (ourStory.currentTags.Contains("them"))
        {
            rightText.text += text;
            //currentAnimator = rightAnimator;
        }

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

    //void ArrayIndexingExample(int slot)
    //{
        //string[] text = new string[3] {"first", "second", "third" };
        //int[] numbers = new int[5] { 234, 567, 654, 10, 12};

        //text[slot] = "Hello, world.";
        //numbers[slot] = 123;


    //}

} 

