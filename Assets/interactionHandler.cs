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
            theObject.GetComponent<Collider2D>().isTrigger = false;
            Destroy(body2d);
            Destroy(animator);
            Destroy(box);
            otherBody.constraints = RigidbodyConstraints2D.None;
            theObject.transform.position = new Vector3(1598, 85, 0);
            FindObjectOfType<DialogueManager>().TextDialogue("The rope creaks and snaps!");
            FindObjectOfType<DialogueManager>().setTimer(4.0f);
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
        if (interactionIndex == 5)
        {
            bool destroyed = false;
            GameObject[] gos = GameObject.FindGameObjectsWithTag("Player");
            foreach (GameObject player in gos)
            {
                foreach (Properties item in player.GetComponent<inventory>().itemList)
                {
                    if (item.itemIndex == 6) //book
                    {
                        Destroy(theObject);
                        FindObjectOfType<DialogueManager>().TextDialogue("You put the book on the bookshelf, and it slides into the ground!");
                        FindObjectOfType<DialogueManager>().setTimer(4.0f);
                        GameObject door1 = GameObject.Find("door hitbox"); door1.GetComponent<MoveScene2d>().enable = true;
                        Properties prop = gameObject.AddComponent<Properties>();
                        prop.Name = "Damnation"; //inventory object so if they leave the cabin nothing will break
                        prop.Description = "Don't go downstairs.";
                        prop.itemIndex = 19;
                        destroyed = true;
                    }
                }
            }
            if (!destroyed)
            {
                FindObjectOfType<DialogueManager>().TextDialogue("A book seems to be missing. . .");
                FindObjectOfType<DialogueManager>().setTimer(4.0f);
            }
        }
    }
}
