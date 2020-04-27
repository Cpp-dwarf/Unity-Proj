using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreventDuplicateCanvas : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int counter = 0;
        GameObject[] players = GameObject.FindGameObjectsWithTag("Canvas");
        foreach (GameObject p in players)
        {
            counter++;
        }
        if (counter == 2)
        {
            //Destroy(players[1]);
        }

    }

}
