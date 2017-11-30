using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlayers : MonoBehaviour
{
    Vector3 currentpos;
    // Use this for initialization
    void Start()
    {
        if (gameObject.tag.Equals("player") == true)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 170f);
        }
      
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag.Equals("colliderv2") == true)
        {
            this.GetComponent<Rigidbody2D>().freezeRotation = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -170f);
        }
       else if (collision.collider.tag.Equals("collider") == true)
        {
            this.GetComponent<Rigidbody2D>().freezeRotation = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 170f);
        }
       
    }

}
