using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutsideRopeHandler : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    Rigidbody2D body2d;
    BoxCollider2D box;
    Rigidbody2D body;

    public GameObject theObject;

    void Start()
    {
        animator = GetComponent<Animator>();
        body2d = theObject.GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Interact()
    {
        body2d.constraints = RigidbodyConstraints2D.None;

    }
}
