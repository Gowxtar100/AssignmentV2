﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {
    keeper1 keeper1; //Loads the Keeper1 class
    Vector3 keeperBallPosDiff;
    bool gamestarted = false; //Declares that game has not started yet
    // Use this for initialization
    void Start () {
        keeper1 = GameObject.FindObjectOfType<keeper1>(); //Finds the keeper1 object
        keeperBallPosDiff = this.transform.position - keeper1.transform.position; 

    }
	
	// Update is called once per frame
	void Update () {

        if (!gamestarted) //if game has not started
        {
            this.transform.position = keeper1.transform.position + keeperBallPosDiff; //Makes the ball follow the keeper
        }

        if (Input.GetKey(KeyCode.Mouse2) && !gamestarted) //if middle mouse button is pressed and game has not started
        {
            gamestarted = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(10f, 0f); //Makes the ball shoot out with velocity 
        }

    }

  


}

