using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keeper2 : MonoBehaviour {
    public float speed = 10f;
    public static int positionIterations;
    // Use this for initialization
    void Start () {
        Physics2D.positionIterations = 20;
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag.Equals("colliderv2") == true)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        }
    }




}
