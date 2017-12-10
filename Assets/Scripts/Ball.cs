using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
    public Paddle2 paddle;
    Vector3 ballPaddleDiff;
    bool gameStarted = false;
    private Rigidbody2D rb2d;
    private Vector2 vel;
    public float ballInitialVelocity = 600f;
    int n = 0;
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


        //void OnCollisionEnter2D(Collision2D col) {
        //    // Note: 'col' holds the collision information. If the
        //    // Ball collided with a racket, then:
        //    //   col.gameObject is the racket
        //    //   col.transform.position is the racket's position
        //    //   col.collider is the racket's collider

        //    // Hit the left Racket?
        //    if (col.gameObject.name == "RacketLeft")
        //    {
        //        // Calculate hit Factor
        //        float y = hitFactor(transform.position,
        //                            col.transform.position,
        //                            col.collider.bounds.size.y);

        //        // Calculate direction, make length=1 via .normalized
        //        Vector2 dir = new Vector2(1, y).normalized;

        //        // Set Velocity with dir * speed
        //        GetComponent<Rigidbody2D>().velocity = dir * speed;
        //    }

        //    // Hit the right Racket?
        //    if (col.gameObject.name == "RacketRight")
        //    {
        //        // Calculate hit Factor
        //        float y = hitFactor(transform.position,
        //                            col.transform.position,
        //                            col.collider.bounds.size.y);

        //        // Calculate direction, make length=1 via .normalized
        //        Vector2 dir = new Vector2(-1, y).normalized;

        //        // Set Velocity with dir * speed
        //        GetComponent<Rigidbody2D>().velocity = dir * speed;
          //  }
        }








    }

