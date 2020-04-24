using UnityEngine;
using System.Collections.Generic;

public class CharacterStats : MonoBehaviour 
{
    public int maxHealth = 100;
    public int currHealth /*= 100*/;
    public int statCost = 2;
    public int points = 10;

    public Bandit m_animator;
    public HealthBar healthBar;

    public Stat damage;
    public Stat armor;
    public Stat STR { get; set; } //strength
    public Stat LCK { get; set; } //luck
    public Stat INT { get; set; } //intelligence
    public Stat DEX { get; set; } //dexterity
    public Stat DEF { get; set; } // defense
    public Stat FTH { get; set; } // faith
    public Stat SNK { get; set; } // sneak
    public Stat CHA { get; set; } //charisma
    public Stat XP { get; set; } // experience
    public string charName { get; set; }

    void Start()
    {
        currHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }


    void Update ()
    {
        //test to see if player takes damage
        if (Input.GetKeyDown("t"))
        {
            TakeDamage(10);
        }
    }

    public void TakeDamage (int damage)
    {
        //player animation
        m_animator.SetTrigger("Hurt");
        //take into account the armor
        damage -= armor.GetVal();
        damage = Mathf.Clamp(damage, 0, int.MaxValue);
        currHealth -= damage;
        healthBar.SetHealth(currentHealth);
        
        if (currHealth <= 0)
        {
            Die();
        }
    }

    public virtual void Die ()
    {
        //player animation
        m_animator.SetTrigger("Death");
    }

}
