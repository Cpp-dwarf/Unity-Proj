using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
public class SkeletonGFX : MonoBehaviour
{

    public AIPath aiPath;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (aiPath.desiredVelocity.x >= .01f)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (aiPath.desiredVelocity.x <= -.01f)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
            
        }
    }
}
