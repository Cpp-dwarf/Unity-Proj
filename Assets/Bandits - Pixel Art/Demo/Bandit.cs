using UnityEngine;
using System.Collections;

public class Bandit : MonoBehaviour {

    [SerializeField] float      m_speed = 1.0f;
    [SerializeField] float      m_jumpForce = 2.0f;

    private Animator            m_animator;
    private Rigidbody2D         m_body2d;
    private Sensor_Bandit       m_groundSensor;
    private bool                m_grounded = false;
    private bool                m_combatIdle = false;
    private float DialogueTimeout = 3.0f;
    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 0.5f;
    public LayerMask enemyLayers;
    public LayerMask dialogueLayers;
    public int attackDamage = 20;
    private float lastVelocity = 0;
    
   
   
    
    // Use this for initialization
    void Start () {
        m_animator = GetComponent<Animator>();
        m_body2d = GetComponent<Rigidbody2D>();
        m_groundSensor = transform.Find("GroundSensor").GetComponent<Sensor_Bandit>();
    }
	
	// Update is called once per frame
	void Update () {
        if(DialogueTimeout > 0.0f)
        {
            DialogueTimeout -= Time.deltaTime;
            if(DialogueTimeout <= 0.0f)
            {
                FindObjectOfType<DialogueManager>().ClearDialogue();
            }
        }
        //Check if character just landed on the ground
        m_grounded = lastVelocity > -.01 && lastVelocity < .01 && m_body2d.velocity.y > - .01 && m_body2d.velocity.y < .01;
        lastVelocity = m_body2d.velocity.y;
        m_animator.SetBool("Grounded", m_grounded);
        
        // -- Handle input and movement --
        float inputX = Input.GetAxis("Horizontal");

        // Swap direction of sprite depending on walk direction
        if (inputX > 0)
            GetComponent<SpriteRenderer>().flipX = true;
        else if (inputX < 0)
            GetComponent<SpriteRenderer>().flipX = false;

        // Move
        m_body2d.velocity = new Vector2(inputX * m_speed, m_body2d.velocity.y);

        //Set AirSpeed in animator
        m_animator.SetFloat("AirSpeed", m_body2d.velocity.y);

        // -- Handle Animations --
        //Death
        if (Input.GetKeyDown("e"))
        {
            Interact();
        }

        //Hurt
        else if (Input.GetKeyDown("q"))
        {
            Dialogue();
        }
        //Attack
       /* else if (Input.GetMouseButtonDown(0))
        {
            m_animator.SetTrigger("Attack");
        }*/
        //Jump
        else if (Input.GetKeyDown("space"))
        {
            if (m_grounded) { 
            m_animator.SetTrigger("Jump");
            m_grounded = false;
            m_animator.SetBool("Grounded", m_grounded);
            m_body2d.velocity = new Vector2(m_body2d.velocity.x, m_jumpForce);
            m_groundSensor.Disable(0.2f); }
        }

        //Run
        else if (Mathf.Abs(inputX) > Mathf.Epsilon)
            m_animator.SetInteger("AnimState", 2);

        //Combat Idle
        else if (m_combatIdle)
            m_animator.SetInteger("AnimState", 1);

        //Idle
        else
            m_animator.SetInteger("AnimState", 0);
    }


    void Interact()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        //physics simulation for interactions
        foreach (Collider2D enemy in hitEnemies)
        {
            Debug.Log("we interacted " + enemy.name);
            
            enemy.GetComponent<interactionHandler>().Interact();
            
        }
    }
    void Dialogue()
    {
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, dialogueLayers);
        //physics simulation for interactions
        foreach (Collider2D enemy in hitEnemies)
        {
            DialogueTimeout = 3.0f;
            Debug.Log("we dialogued " + enemy.name);
            enemy.GetComponent<DialogueTrigger>().TriggerDialogue();
            
            
        }
    }

  
}
