using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    //singleton design pattern- when only one of something needs to exist
    public static ScoreManager instance;

    public TextMeshProUGUI scoreText;

    int leftScore = 0;
    int rightScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    public void AddScore(bool didLeftScore, int pointsScored)
    {
        if (didLeftScore)
        {
            leftScore += pointsScored;
        }
        else { rightScore += pointsScored; }
        Debug.Log(leftScore + " : " + rightScore);
        scoreText.text = leftScore + " : " + rightScore;
    }
}
