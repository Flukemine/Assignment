using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreenScore : MonoBehaviour {
    Text winner;
    int score1;
    int score2;
    // Use this for initialization
    void Start () {
       score1 = Score1left.scores1player2;
       score2 = Scorerights.scores1;
        
       winner = GetComponent<Text>();
       
       
    }
	
	// Update is called once per frame
	void Update () {
      if(score1 > score2)
        {
            winner.text = "The winner is player1";
        }
        else {
            winner.text = "The winner is player2";
        }
    }
}
