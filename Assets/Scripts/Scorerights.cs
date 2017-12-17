using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Scorerights : MonoBehaviour
{
    Text myScore;
    public static int scores1;
    int counts = 0;
    // Use this for initialization
    void Start()
    {
        myScore = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        myScore.text = "Player2: " + scores1;
    }

    public void OnCollisionEnter2D(Collision2D collsion)
    {
  
        scores1 = (scores1 + 1) + counts;
     
        
        if (collsion.gameObject.name =="ball" )
        {
            if (scores1 == 3)
            {
                SceneManager.LoadScene("Level2");
             
                counts = 0;
            }
        }
        if (collsion.gameObject.name  == "ball2")
        {
            if (scores1 >= 6)
            {
                SceneManager.LoadScene("Level3");
                
            }
            counts = 2;
        }
        if (collsion.gameObject.name == "ball3")
        {
            if (scores1 >= 12)
            {
                SceneManager.LoadScene("EndScreen");
                
                
            }
            counts = 3;
        }
       

    }


      

        }

     




   