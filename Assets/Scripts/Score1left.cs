using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Score1left : Scorerights
{
    public static int scores1player2;
    int count = 0;
    public  Text text;
    Text winner;
    // Use this for initialization
    void Start() {

        // UpdateScore(scores1player2);
        text = GetComponent<Text>();
        winner = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update() {
        text.text = "Player 1: " + scores1player2;
        if (scores1player2 == 6 || scores1 == 6)
        {
            Winner();
        }
      
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
       // scores1player2++;
        scores1player2 = (scores1player2 + 1) + count;
       // UpdateScore(scores1player2);
       // ArrayList totalScore2 = new ArrayList();
        if (collision.gameObject.name == "ball")
        {
            if (scores1player2 == 3)
            {

                SceneManager.LoadScene("Level2");
             //   totalScore2.Add(2);
                

            }
            count = 0;

        }

        if (collision.gameObject.name == "ball2")
        {
            if (scores1player2 >= 6)
            {
                SceneManager.LoadScene("Level3");
            //    totalScore2.Add(5);
               // count = 2;
            }
            count = 2;
        }

        if (collision.gameObject.name == "ball3")
        {
            if (scores1player2 >= 12)
            {
                SceneManager.LoadScene("EndScreen");
              //  totalScore2.Add(6);
                
            }
            count = 3;
        }

    }
    void Winner()
    {
        if (scores1player2 > scores1)
        {
            winner.text = "The winner is" + "player1";
        }
        else
        {
            winner.text = "The winner is" + "player2";
        }
    }

}
