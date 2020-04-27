using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private static SceneLoader _instance;
    public static SceneLoader instance //Singleton stuff
    {
        get
        {
            if(_instance == null)
            {
                GameObject loader = new GameObject("[Scene Loader]");
                _instance = loader.AddComponent<SceneLoader>();
            }
            return _instance;
        }
    }

    public static string lastTrigger; //

    public void OnEnteredExitTrigger(string triggerName, string levelToLoad) //Called from MoveScene2d (The script on all door colliders to check if player wants to enter)
    {
        GameObject player = GameObject.FindWithTag("Player"); //Makes sure player isnt destroyed on load
        DontDestroyOnLoad(player);
        GameObject DialogueManager = GameObject.FindWithTag("DialogueManager"); //Makes sure dialoguemanager isnt destroyed on load
        GameObject Canvas = GameObject.FindWithTag("Canvas");
        DontDestroyOnLoad(DialogueManager);
        DontDestroyOnLoad(Canvas);
        
       
        lastTrigger = triggerName;
        SceneManager.LoadScene(levelToLoad); //Loads scene
    }
    
    void OnEnable() //Tells program to be on the lookout for a scene load event
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnDisable() //Disables...
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }


    void OnSceneLoaded(Scene scene, LoadSceneMode mode) //Checks all triggernames for the matching one so that the player spawns in the right place when changing scenes
    {
        MoveScene2d[] allExits = FindObjectsOfType<MoveScene2d>();
        foreach (MoveScene2d exit in allExits)
        {
            if (exit.triggerName == lastTrigger)
            {
                transform.parent.position = exit.spawnPoint.position;
                return;

            }
        }       
    }
}
