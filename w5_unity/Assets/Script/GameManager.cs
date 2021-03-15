using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Text text;
    private bool gameOver = false;
    private int foodAmount;
    public GameObject person;
    // Start is called before the first frame update
    public int FoodAmount
    {
        get { return foodAmount;}
        set
        {
            foodAmount = value;
        }
    }
    private void Awake()
    {
        foodAmount = 8;
        if (instance == null) //instance hasn't been set yet
        {
            DontDestroyOnLoad(gameObject);  //Dont Destroy this object when you load a new scene
            instance = this;  //set instance to this object
        }
        else  //if the instance is already set to an object
        {
            Destroy(gameObject); //destroy this new object, so there is only ever one
        }
    }

    void Start()
    {
       
    }

    // Update is called once per frame
   void Update()
    {
        float currentWidth=person.GetComponent<Eat>().PersonWidth;
        //float currentWidth=Eat.instance.PersonWidth;
        if (currentWidth >= 1 && currentWidth <= 1.2 && gameOver == false)
        {
           
            text.text = "Stisfied ^_^";
            SceneManager.LoadScene(3);
            gameOver = true;

        }
        if (currentWidth > 1.2 && gameOver == false)
        {
            text.text = "Tooooooo Full XD";
            SceneManager.LoadScene(3);
            gameOver = true;
            
        }
        
    }
   
}
