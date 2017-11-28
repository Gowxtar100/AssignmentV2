using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Goalpost : MonoBehaviour {
 
    public Text player1score;
    public string sceneName;
    public int scorenumber;
    public int maxscore;
    int scoreone;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (scoreone == maxscore)
        {
            SceneManager.LoadScene(sceneName);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        scoreone = scoreone + scorenumber ;
        player1score.text = ("Score : " + scoreone);
    }
}
