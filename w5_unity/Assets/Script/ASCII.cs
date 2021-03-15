using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.SceneManagement;

public class ASCII : MonoBehaviour
{
    public static ASCII instance;
    public GameObject personEat;
    public GameObject Wall;
    public float xOffset;
    public float yOffset;
    public string file_name;
    public int level;
    
    // public int Level
    // {
    //     get { return level;}
    //     set
    //     {
    //         level = value;
    //         LoadMap();
    //     }
    // }
    
    void Start()
    {
        //SceneManager.LoadScene(1);
       
    }

    private void Awake()
    {
        //SceneManager.LoadScene(level);
        LoadMap();
    }

    void LoadMap()
    {

        string current_file_path =
            Application.dataPath +
            "/Maps/" +
            file_name;
                //.Replace("?", level + "");
        // string fileText = File.ReadAllText(current_file_path);
        string[] fileLines = File.ReadAllLines(current_file_path);
        for(int y=0; y<fileLines.Length;y++)
        {
            string fileText = fileLines[y]; 
            char[] characters = fileText.ToCharArray();
            for (int x = 0; x < characters.Length; x++)
            {
                char c = characters[x];
                if (c == 'w')
                {
                    GameObject newWall;
                    newWall = Instantiate(Wall);
                    newWall.transform.position = new Vector2(xOffset + x, yOffset-y);
                }
            }
        }
    } 
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
