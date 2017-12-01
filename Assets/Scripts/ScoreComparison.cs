using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreComparison : MonoBehaviour {

    public Text Winner;

	// Use this for initialization
	void Start () {
        if (ScoreStorage.Scoreone > ScoreStorage.Scoretwo)
        {
            Winner.text = "Player 2 wins";
        }
        if (ScoreStorage.Scoreone < ScoreStorage.Scoretwo)
        {
            Winner.text = "Player 1 wins";
        }
    }
	
	// Update is called once per frame
	void Update () {
		
    }
}
