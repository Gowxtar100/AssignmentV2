﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keeper1 : MonoBehaviour {
    public float speed = 1f;
    public static int positionIterations;
    // Use this for initialization
    void Start()
    {
        Physics2D.positionIterations = 20;


    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            transform.position += new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
        }
        if (Input.GetKey(KeyCode.Mouse1))
        {
            transform.position -= new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
        }
        this.GetComponent<Rigidbody2D>().freezeRotation = true;


    
       
        
    }
}
