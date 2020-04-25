using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class startupCam : MonoBehaviour
{
    public CinemachineVirtualCamera followcam;
    // Start is called before the first frame update
    void Start()
    {
        followcam.Follow = GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
