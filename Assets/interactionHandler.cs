using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
// written by sage shuster
public class interactionHandler : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;
    Rigidbody2D body2d;
    Rigidbody2D otherBody;
    BoxCollider2D box;
    SpriteRenderer render;
    int active = 0;
   

    public GameObject theObject;
    public int interactionIndex;
    public Text DescriptiveText;
     public GameObject otherButton;
    public GameObject otherButton2;//if it is a sequence puzzle, what poart in sequence is this button
    //int sequence = 0;

    void Start()
    {
        //object with scripts vars
        animator = GetComponent<Animator>();
        body2d = GetComponent<Rigidbody2D>();
        box = GetComponent<BoxCollider2D>();
        render = GetComponent<SpriteRenderer>();
        //vars for the object targeted
        otherBody = theObject.GetComponent<Rigidbody2D>();

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
        if (interactionIndex == 1)
        {
            body2d.constraints = RigidbodyConstraints2D.None;
        }

        //inside trader button interact
        if (interactionIndex == 2)
        {
            active = 1;
            render.color = Color.green;
            Destroy(box);
            int temp = otherButton.GetComponent<interactionHandler>().active;
            int temp2= otherButton.GetComponent<interactionHandler>().active;
            if (temp == 1 && temp2==1)
           {
               otherBody.constraints = RigidbodyConstraints2D.None;
               theObject.transform.position = new Vector3(1182, 116, 0);
            }
        }
        //platform interaction house 2
        if (interactionIndex == 3)
        {
            render.color = Color.green;
            otherBody.constraints = RigidbodyConstraints2D.None;
            theObject.transform.position = new Vector3(1167, 122, 0);

        }
        //default item pickup
        if (interactionIndex == 4)
        {
            Destroy(body2d);
            Destroy(animator);
            Destroy(box);
            Destroy(render);
            DescriptiveText.text = "You've obtained the Traveller's walking stick";

        }
        if (interactionIndex == 5)
        {
            Destroy(body2d);
            Destroy(animator);
            Destroy(box);
            Destroy(render);
            DescriptiveText.text = "You've obtained the Traveller's Gem!";

        }
    }
}
