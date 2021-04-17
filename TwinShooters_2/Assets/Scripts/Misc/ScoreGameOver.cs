using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreGameOver : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject GameplayCanvas;
    private Score inGameScore;

    private float lastScore;

    public TextMeshProUGUI scoreText;

    void Start()
    {
    	GameplayCanvas = GameObject.Find("InGameCanvas");
        inGameScore = GameplayCanvas.GetComponent<Score>();
        lastScore = inGameScore.score;
    }

    // Update is called once per frame
    void Update()
    {
    	lastScore = inGameScore.score;
        scoreText.text = lastScore.ToString() + " second(s)";
    }
}
