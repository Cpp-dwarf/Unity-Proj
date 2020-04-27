using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DialogueManager : MonoBehaviour
{   
    public Text DialogueText;
    public Image Profile;
    private float Timer = 6.0f;
    private static bool hasStarted = false;
    
    void Start()
    {
        if (!hasStarted)
        {
            DialogueText.text = "You're looking for a friend. Press 'q' to talk.";
            hasStarted = true;
        }
    }

    void Update()
    {
        if(Timer > 0.0f)
        {
            Timer -= Time.deltaTime;
            if(Timer <= 0.0f)
            {
                ClearDialogue();
            }
        }
    }

    public void setTimer(float time)
    {
        Timer = time;
    }

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

    public void TextDialogue(string t)
    {
        SpriteRenderer[] sprites = GetComponentsInChildren<SpriteRenderer>();
        foreach (SpriteRenderer s in sprites)
        {
            Profile.sprite = s.sprite;
        }
        DialogueText.text = t;
    }
}
