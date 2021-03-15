using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eat : MonoBehaviour
{
    public static Eat instance;
    private float personWidth ;
    private string foodname;
    private float calorise; 
    
    public float PersonWidth
    {
        get { return personWidth;}
        set
        {
            personWidth = value;
        }
    }
    
    private void Awake()
    {   
         personWidth = (float) 0.5;
        //
        // if (instance == null)  //instance hasn't been set yet
        // {
        //     DontDestroyOnLoad(gameObject);  //Dont Destroy this object when you load a new scene
        //     instance = this; //set instance to this object
        // }
        // else //if the instance is already set to an object
        // {
        //     Destroy(gameObject);  //destroy this new object, so there is only ever one
        // }
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector2(personWidth, (float)0.7);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        
        calorise = other.gameObject.GetComponent<FoodMove>().foodCal;
        PersonWidth += calorise;
        Destroy(other.gameObject);
        Debug.Log(personWidth);
        
       
        
    }



 
}
