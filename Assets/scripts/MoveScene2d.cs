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

    void OnTriggerEnter2D(Collider2D x)
    {
        if (x.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            if (enable)
            {
                SceneLoader.instance.OnEnteredExitTrigger(triggerName, levelToLoad);
                enable = false;
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
        }
    }
}

