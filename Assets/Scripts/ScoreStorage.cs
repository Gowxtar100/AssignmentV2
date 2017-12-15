using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreStorage : MonoBehaviour
{

    public Text play1score;
    public Text play2score;

    private static int scoreone, scoretwo;

    public static int Scoreone
    {
        get
        {
            return scoreone;
        }
        set
        {
            scoreone = value;
        }
    }
    public static int Scoretwo
    {
        get
        {
            return scoretwo;
        }
        set
        {
            scoretwo = value;
        }
    }


}
