﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class GFXhandler : MonoBehaviour
{

    public AIPath aiPath;

    // Start is called before the first frame update
   

    // Update is called once per frame
    void Update()
    {
        if(aiPath.desiredVelocity.x >= .01f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else if (aiPath.desiredVelocity.x <= -.01f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
