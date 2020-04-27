using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene2d : MonoBehaviour
{
    public string triggerName;
    public string levelToLoad;
    public Transform spawnPoint;
    public bool enable = true; //Enable is so that if the door behind the bookshelf does not look for the player while the bookshelf is in front of it
    public int enablerItem = -1;
    public bool hidden = false;

    void Start()
    {
        //Search Player Inventory for enabler item
        GameObject[] gos = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject player in gos)
        {
            foreach (Properties item in player.GetComponent<inventory>().itemList)
            {
                if (item.itemIndex == enablerItem)
                {
                    enable = true;
                }
            }
        }
    }

    void OnTriggerEnter2D(Collider2D x)
    {
        if (x.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            if (enable)
            {
                SceneLoader.instance.OnEnteredExitTrigger(triggerName, levelToLoad);
                enable = false;
            }
            else if(!hidden)
            {
                FindObjectOfType<DialogueManager>().TextDialogue("You can't open the door . . .");
                FindObjectOfType<DialogueManager>().setTimer(3.0f);
            }
        }
    }

    void OnTriggerStay2D(Collider2D x)
    {
        if (x.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            if (enable)
            {
                SceneLoader.instance.OnEnteredExitTrigger(triggerName, levelToLoad);
                enable = false;
            }
            else if (!hidden)
            {
                FindObjectOfType<DialogueManager>().TextDialogue("You can't open the door . . .");
                FindObjectOfType<DialogueManager>().setTimer(3.0f);
            }
        }
    }
}

