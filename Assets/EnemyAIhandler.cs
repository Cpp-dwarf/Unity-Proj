using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;


public class EnemyAIhandler : MonoBehaviour
{

    [SerializeField] float m_speed = 1.0f;
    [SerializeField] float m_jumpForce = 2.0f;

    private Animator m_animator;
    private Rigidbody2D m_body2d;
    private Sensor_Bandit m_groundSensor;
    private bool m_grounded = false;
    private bool m_combatIdle = false;
    private bool m_isDead = false;
    //custom 
    public int maxHealth = 100;
    public int currentHealth;
    public Animator animator;
    public string name = "Skeletron";
    // Start is called before the first frame update
    void Start()
    {
       
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        animator.SetTrigger("Hurt");
        if(currentHealth <= 0 )
        {
            Die();
        }
    }
    public void Die()
    {
        animator.SetBool("Dead", true);
        this.enabled = false;



        
    }
}
