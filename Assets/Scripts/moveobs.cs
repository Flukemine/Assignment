using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveobs : MonoBehaviour {
    Transform myTransform;
    float speed = 0.2f;
    // Use this for initialization
    void Start () {
        myTransform = transform;
      
    }
	
	// Update is called once per frame
	void Update () {

        //  MoveUp();
        //  MoveDown();

        
        myTransform.position = new Vector2(myTransform.position.x, myTransform.position.y + speed);
        myTransform.position = new Vector2(myTransform.position.x, myTransform.position.y);
        print(myTransform.position);
        if (myTransform.position.y == 4.0f)
        {
            myTransform.position = new Vector2(myTransform.position.x, myTransform.position.y - 8.8f);
        }
          Vector3 clampedPosition = transform.position;
          clampedPosition.y = Mathf.Clamp(transform.position.y, -4.1f, 3.8f);
          transform.position = clampedPosition;



    }

    void MoveUp()
    {
        myTransform.position = new Vector2(myTransform.position.x, myTransform.position.y + speed);
        if (myTransform.position.y == 4.1f)
        {
            MoveDown();
        }
    }

    void MoveDown()
    {
        myTransform.position = new Vector2(myTransform.position.x, myTransform.position.y - speed);
        if (myTransform.position.y == 4.1f)
        {
            MoveUp();
        }
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        myTransform.position = new Vector2(myTransform.position.x, myTransform.position.y - speed);
    }


}
