using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class interactionHandler : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    Rigidbody2D body2d;
    Rigidbody2D otherBody;
    BoxCollider2D box;
  
    public GameObject theObject;
    public int interactionIndex ;
    public Text DescriptiveText;

    void Start()
    {
        //object with scripts vars
         animator = GetComponent<Animator>();
         body2d = GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();
        //vars for the object targeted
        otherBody=theObject.GetComponent<Rigidbody2D>();

    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
   public void Interact()
    {
        if (interactionIndex == 0)//outside rope pulley interaction
        {
            Destroy(body2d);
            Destroy(animator);
            Destroy(box);
            otherBody.constraints = RigidbodyConstraints2D.None;
            theObject.transform.position = new Vector3(1072, 85, 0);
            DescriptiveText.text = "The rope creaks and snaps, dropping the crate";
        }
        if(interactionIndex==1)
        {
            body2d.constraints = RigidbodyConstraints2D.None;
        }
    }
}
