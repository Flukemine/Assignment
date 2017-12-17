using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {
    float speed = 0.2f;       // how far the paddle moves per frame
    Transform myTransform;
 
    // Use this for initialization
    void Start () {
        myTransform = transform;
    }
	
	// Update is called once per frame
	void Update () {



        

        if (Input.GetKey("w"))
            MoveUp();
        else if (Input.GetKey("s"))
            MoveDown();

        Vector3 clampedPosition = transform.position;
        clampedPosition.y = Mathf.Clamp(transform.position.y, -4.1f, 4.1f);
        transform.position = clampedPosition;


    }

    void MoveUp()
    {
        myTransform.position = new Vector2(myTransform.position.x, myTransform.position.y + speed);
    }

    // move the player's paddle down by an amount determined by 'speed'
    void MoveDown()
    {
        myTransform.position = new Vector2(myTransform.position.x, myTransform.position.y - speed);
    }

    
}
