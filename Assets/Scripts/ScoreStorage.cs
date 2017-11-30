using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreStorage : MonoBehaviour {

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
