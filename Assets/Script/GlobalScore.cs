
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalScore : MonoBehaviour {

    public static int CurrentScore;
    public int InternalScore;
    public Text ScoreDisplay;

    private void Update()
    {
        InternalScore = CurrentScore;
        ScoreDisplay.text = "Score: " + InternalScore;
    }
}
