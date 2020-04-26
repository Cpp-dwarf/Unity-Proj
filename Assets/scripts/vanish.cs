using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vanish : MonoBehaviour
{
    // Start is called before the first frame update
    public int vanishIndex = 0;
    void Start()
    {
        GameObject[] gos = GameObject.FindGameObjectsWithTag("Player");
        foreach (GameObject player in gos)
        {
            foreach (Properties item in player.GetComponent<inventory>().itemList)
            {
                if (item.itemIndex == vanishIndex)
                {
                    Destroy(this.gameObject);
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
