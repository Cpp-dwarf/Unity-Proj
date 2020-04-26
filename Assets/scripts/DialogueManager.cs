using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueManager : MonoBehaviour
{   
    public Text DialogueText;
    public Image Profile;
    
    public void StartDialogue(Dialogue dialogue)
    {
        Profile.sprite = dialogue.profile;
        DialogueText.text = dialogue.sentences[dialogue.index];
    }

    public void ClearDialogue()
    {
        SpriteRenderer[] sprites = GetComponentsInChildren<SpriteRenderer>();
        foreach (SpriteRenderer s in sprites)
        {
            Profile.sprite = s.sprite;
        }
        DialogueText.text = "";
    }
}
