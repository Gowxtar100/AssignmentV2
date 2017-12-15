using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreComparison : MonoBehaviour
{
    public Text play1score;
    public Text play2score;
    public Text Winner;

    // Use this for initialization
    void Start()
    {
        if (ScoreStorage.Scoreone > ScoreStorage.Scoretwo)
        {
            Winner.text = "Player 2 wins";
            play1score.text = ("Player 2 Final Score: " + ScoreStorage.Scoreone.ToString());
            play2score.text = ("Player 1 Final Score: " + ScoreStorage.Scoretwo.ToString());
        }
        if (ScoreStorage.Scoreone < ScoreStorage.Scoretwo)
        {
            Winner.text = "Player 1 wins";
            play1score.text = ("Player 2 Final Score: " + ScoreStorage.Scoreone.ToString());
            play2score.text = ("Player 1 Final Score: " + ScoreStorage.Scoretwo.ToString());
        }

        ScoreStorage.Scoreone = 0;
        ScoreStorage.Scoretwo = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
