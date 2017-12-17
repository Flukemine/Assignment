using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public Paddle2 paddle;
    Vector3 ballPaddleDiff;
    bool gameStarted = false;
    private Rigidbody2D rb2d;
    // Use this for initialization
    void Start () {
        paddle = GameObject.FindObjectOfType<Paddle2>();
        ballPaddleDiff = this.transform.position - paddle.transform.position;
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () {

      //  if (!gameStarted)
       // {
       //     this.transform.position = paddle.transform.position + ballPaddleDiff;
       // }

        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            gameStarted = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
            float rand = Random.Range(0, 2);
            if (rand < 1)
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(20, -15);
               
            }
            else
            {
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(-20, 15);
               
            }



            
        }

        
      
        }








    }

