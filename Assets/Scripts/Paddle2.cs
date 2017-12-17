using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle2 : MonoBehaviour {
   
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //print(Input.mousePosition.y);

        float mousePostInUnits = (Input.mousePosition.y / Screen.height * 10) - 5;
        //
        Vector3 newPaddlePos = new Vector3(gameObject.transform.position.x, mousePostInUnits, gameObject.transform.position.z);



        newPaddlePos.y = Mathf.Clamp(mousePostInUnits, -4.1f, 4.1f);
        gameObject.transform.position = newPaddlePos;

    }

   
}
