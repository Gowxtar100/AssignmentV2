using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Goalpost : MonoBehaviour
{

    public Text player1score;
    public string sceneName;
    public int scorenumber;
    public int maxscore;
    int currentscore = 0;



    // Use this for initialization
    void Start()
    {
        player1score.text = currentscore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentscore >= maxscore)
        {

            SceneManager.LoadScene(sceneName);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        currentscore = currentscore + scorenumber;
        ScoreStorage.Scoreone = ScoreStorage.Scoreone + scorenumber;
        player1score.text = currentscore.ToString();

    }

}

