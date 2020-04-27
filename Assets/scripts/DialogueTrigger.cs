using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        dialogue.index++;
        if(dialogue.index >= dialogue.sentences.Length)
        {
            dialogue.index = dialogue.sentences.Length-1;
        }
    }
}
