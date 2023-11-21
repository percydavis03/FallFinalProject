using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public NPCDetect npcDetect;

    bool isTalking = false;

    float distance;
    float curResponseTracker = 0;

    public GameObject player;
    public GameObject dialogueUI;

    public Text npcName;
    public Text npcDialogueBox;
    public Text playerResponse;




    // Start is called before the first frame update
    void Start()
    {
        dialogueUI.SetActive(false);
    }

    private void OnMouseOver()
    {
        distance = Vector3.Distance(player.transform.position, this.transform.position);  
        if(distance <= 2.5f)
        {
            if (Input.GetKeyDown(KeyCode.F) && isTalking==false)
            {
                StartConversation();
                Debug.Log("Startstalking");
            }
            
            else if(Input.GetKeyDown(KeyCode.Escape) && isTalking == true)
            {
                EndDialogue();
                Debug.Log("endstheconversation");

            }

        }

           
    }

    void StartConversation()
    {
        isTalking = true;
        curResponseTracker = 0;
        dialogueUI.SetActive(true);
        npcName.text = npcName.name;
        //npcDialogueBox.text = npc.dialogue[0];
    }

    void EndDialogue()
    {
        isTalking = false;
        dialogueUI.SetActive(false);

    }
}
