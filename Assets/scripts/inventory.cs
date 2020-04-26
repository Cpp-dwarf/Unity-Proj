//Inventory class
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventory : MonoBehaviour
{
    public Transform playerCenter;
    public float pickUpRange = 12;
    public LayerMask itemLayer;
    

    //List of items
    public List<Properties> itemList;

    //Constructor to initialize list    
    public inventory()
    {
        itemList = new List<Properties>();

    }

    public void AddItem(Properties p)
    {
        Properties prop = gameObject.AddComponent<Properties>();
        prop.Name = p.Name;
        prop.Description = String.Copy(p.Description);
        prop.itemIndex = p.itemIndex;
        itemList.Add(prop);
    }


    // Use this for initialization
    void Start()
    {
        //m_animator = GetComponent<Animator>();
        //m_body2d = GetComponent<Rigidbody2D>();
       
    }

    // Update is called once per frame
    void Update()
    {
        //Check if character just landed on the ground
  
        if (Input.GetKeyDown("g"))
        {
            Grab();
        }

    }
    private Properties copyProps(Properties p)
    {
        Properties prop = gameObject.AddComponent<Properties>();
        prop.Name = p.Name;
        prop.Description = String.Copy(p.Description);
        prop.itemIndex = p.itemIndex;
        return prop;
    }
    private void Grab()
    {
        Collider2D[] items = Physics2D.OverlapCircleAll(playerCenter.position, pickUpRange, itemLayer);
        foreach (Collider2D item in items)
        {
            Properties props = copyProps(item.GetComponent<Properties>());
            AddItem(props);
            Debug.Log(item.GetComponent<Properties>().Name);
            Destroy(item.gameObject);
        }
        foreach (Properties item in itemList)
        {
            Debug.Log(item.Name);
        }

    }
}
