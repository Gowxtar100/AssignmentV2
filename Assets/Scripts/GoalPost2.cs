﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GoalPost2 : MonoBehaviour {

    public Text player2score;
    public string sceneName;
    public int scorenumber;
    public int maxscore;

    int scoretwo;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
    
	void Update () {
        if (scoretwo == maxscore)
        {
            SceneManager.LoadScene(sceneName);
        }

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
            scoretwo = scoretwo + scorenumber;
            player2score.text = ("Score : " + scoretwo);

        
    }


}
