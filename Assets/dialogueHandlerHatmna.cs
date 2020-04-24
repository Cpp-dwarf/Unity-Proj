using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//written by sage shuster
public class dialogueHandlerHatmna : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    Rigidbody2D body2d;
    BoxCollider2D box;
    public Image portrait;
    public Text text1;
    public int npcSelect;
    int dialogCount ;
    float timeLeft = 10.0f;
    public Sprite portraitPic;

    //0 for hat
    //1 for fat
    //2 for women
    //3 for other
    //9 for final

    void Start()
    {
        animator = GetComponent<Animator>();
        body2d = GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //timeLeft -= Time.deltaTime;
        //if (timeLeft <= 0)
        //{
         //   clearText();
        //}
    }
    public void Interact()
    {
        //dialogue system, the index provided selects an area of dialogue,
        timeLeft = 10.0f;
        if (npcSelect==0)
        {
            switch(dialogCount)
            {
                case 0:
                    portrait.color = Color.white;
                    portrait.sprite = portraitPic;
                    portrait.enabled = true;
                    text1.text = "Hello, stranger...";
                    dialogCount++;
                    break;

                case 1:
                    text1.text = "People from this neck of the woods dont take kindly to unfamilair faces";
                    dialogCount++;
                    break;
                case 2:
                    text1.text = "However, I suppose you are a visitor...";
                    dialogCount++;
                    break;
                case 3:
                    text1.text = "A friend of yers came through you say?? I suppose I remember a fella last fortnite that looked fresh to town, Dont remember much else";
                    dialogCount++;
                    break;
                case 4:
                    text1.text = "However, you look parched traveler. Get some water from inside.";
                    dialogCount++;
                    break;
                default:
                    text1.text = "I dont remember much else. Water is inside if ya want.";
                    break;
            }
        }
        else if (npcSelect == 1)
        {
            switch (dialogCount)
            {
                case 0://prime example
                    portrait.color = Color.white;
                    portrait.sprite =portraitPic;
                    portrait.enabled = true;
                    text1.text = "Hello Traveller";
                    dialogCount++;
                    break;

                case 1:
                    text1.text = "You must be lost to wind up in this town";
                    dialogCount++;
                    break;
                case 2:
                    text1.text = "Your friend passed through? I have tens of customers a day!, I cannot remember them all";
                    dialogCount++;
                    break;
                case 3:
                    text1.text = "I guess you can look in my home for clues if you wish";
                    dialogCount++;
                    break;

                default:
                    text1.text = "House is right there";
                    break;
            }
        }

       else if (npcSelect == 2)
        {

        }

       else if (npcSelect == 3)
        {

        }

        else if (npcSelect == 9)
        {
            switch (dialogCount)
            {
                case 0://prime example
                    portrait.color = Color.white;
                    portrait.sprite = portraitPic;
                    portrait.enabled = true;
                    text1.text = "Hello Fellow Traveler";
                    dialogCount++;
                    break;

                case 1:
                    text1.text = "You are searching for your companion you say? I am also a visitor in this land, and I do say the people here seem different.";
                    dialogCount++;
                    break;
                case 2:
                    text1.text = "I can help you find your Friend, but as ive stayed in town some of my belongings have gone missing. Could you find them while I ask around?";
                    dialogCount++;
                    break;
                case 3:
                    text1.text = "You can find my possessions by looking around town, I'm sure of it ";
                    dialogCount++;
                    break;

                default:
                    text1.text = "Come back with my stuff ";
                    break;
            }
        }

    }
    void clearText()
    {
        text1.text = "";
    }
}
