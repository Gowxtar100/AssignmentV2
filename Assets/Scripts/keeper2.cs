using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keeper2 : MonoBehaviour {
    public float speed = 10f;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
           transform.position += new Vector3(0.0f, speed * Time.deltaTime, 0.0f);

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position -= new Vector3(0.0f, speed * Time.deltaTime, 0.0f);
        }
        this.GetComponent<Rigidbody2D>().freezeRotation = true;
    }
  

   

    
}
