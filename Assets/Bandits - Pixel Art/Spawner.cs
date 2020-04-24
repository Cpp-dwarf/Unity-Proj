using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int counter = 0;
        GameObject[] players = GameObject.FindGameObjectsWithTag("Player"); //Checks for any extraneous players and deletes them
        foreach(GameObject player in players)
        {
            counter++;
        }
        if (counter == 2)
        {
            Destroy(players[1]);
        }

    }

}
