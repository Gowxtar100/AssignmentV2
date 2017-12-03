using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour {
    Vector3 originalpos;
	// Use this for initialization
	void Start () {
        originalpos = GameObject.FindGameObjectWithTag("colliderv2").transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.position = originalpos;
	}
}
