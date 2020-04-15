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
                    text1.text = "Hello";
                    dialogCount++;
                    break;

                case 1:
                    text1.text = "Im working";
                    dialogCount++;
                    break;
                case 2:
                    text1.text = "The people of this village ";
                    dialogCount++;
                    break;

                default:
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
                    text1.text = "Hello";
                    dialogCount++;
                    break;

                case 1:
                    text1.text = "Im fat and gay";
                    dialogCount++;
                    break;
                case 2:
                    text1.text = "The people of this village ";
                    dialogCount++;
                    break;

                default:
                    break;
            }
        }
       else if (npcSelect == 2)
        {

        }
       else if (npcSelect == 3)
        {

        }

       
    }
    void clearText()
    {
        text1.text = "";
    }
}
