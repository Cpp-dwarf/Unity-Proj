using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactionHandler : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    Rigidbody2D body2d;
    BoxCollider2D box;

    void Start()
    {
         animator = GetComponent<Animator>();
         body2d = GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
   public void Interact()
    {
        Destroy(body2d);
        Destroy(animator);
        Destroy(box);
    }
}
