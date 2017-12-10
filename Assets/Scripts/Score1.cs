using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Score1 : MonoBehaviour {
    int scores1;
    // Use this for initialization
    void Start () {
         scores1 = 0;

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnCollisionEnter2D(Collision2D collsion)
    {
        scores1++;
      
        if (scores1 == 2)
        {
            SceneManager.LoadScene("Level2");
        }
    }
}
