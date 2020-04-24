using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
                    text1.text = "I get so tired of watching people come into the town and none of them coming out.";
                    dialogCount++;
                    break;
                case 1:
                    //Hint on how to solve puzzle
                    text1.text = "";
                    dialogCount++;
                    break;
                case 2:
                    text1.text = "You should just leave while you still can.";
                    dialogCount++;
                    break;

                default:
                    dialogCount = 0;
                    break;
            }
        }
        else if (npcSelect == 1)
        {
            switch (dialogCount)
            {
                case 0://prime example
                    portrait.color = Color.white;
                    portrait.sprite = portraitPic;
                    portrait.enabled = true;
                    text1.text = "If you play your cards right, you might come out of here alive, ha!";
                    dialogCount++;
                    break;

                case 1:
                    //Hint on how to solve the puzzle
                    text1.text = "";
                    dialogCount++;
                    break;
                case 2:
                    text1.text = "I hope you find what you are looking for.";
                    dialogCount++;
                    break;

                default:
                    dialogCount = 0;
                    break;
            }
        }
       else if (npcSelect == 2)
        {
            switch (dialogCount)
            {
                case 0:
                    portrait.color = Color.white;
                    portrait.sprite = portraitPic;
                    portrait.enabled = true;
                    text1.text = "Sometimes, the shadows you see in the woods are more than just shadows.";
                    dialogCount++;
                    break;

                case 1:
                    //Hint on how to solve puzzle
                    text1.text = "";
                    dialogCount++;
                    break;
                case 2:
                    text1.text = "Proceed with caution.";
                    dialogCount++;
                    break;

                default:
                    dialogCount = 0;
                    break;
            }

        }
       else if (npcSelect == 3)
        {
            switch (dialogCount)
            {
                case 0:
                    portrait.color = Color.white;
                    portrait.sprite = portraitPic;
                    portrait.enabled = true;
                    text1.text = "Haven't you been here before? Hm, I guess it was someone else that looked exaclty like you...";
                    dialogCount++;
                    break;

                case 1:
                    //Hint about puzzle
                    text1.text = "";
                    dialogCount++;
                    break;
                case 2:
                    text1.text = "Now that you've reached the end, run and don't look back...whatever you do, DO NOT go into that barn!";
                    dialogCount++;
                    break;

                default:
                    dialogCount = 0;
                    break;
            }
        }

       
    }
    void clearText()
    {
        text1.text = " ";
    }
}
