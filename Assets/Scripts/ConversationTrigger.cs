using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversationTrigger : MonoBehaviour
{
    public DialogAsset dialogAsset;
    public GameObject dialogPreffab;

    void Start()
    {
        StartDialog();
    }


    public void StartDialog()
    {
        GameObject dialog = Instantiate(dialogPreffab);  
        StoryManager storyManager = dialog.GetComponent<StoryManager>();

        storyManager.storyJson = dialogAsset.storyJson;
        storyManager.rightImage.sprite = dialogAsset.portrait;
        storyManager.RightAnimator.runtimeAnimatorController = dialogAsset.animatorController;

    }

}
