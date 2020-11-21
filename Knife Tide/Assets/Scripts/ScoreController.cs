using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreController : MonoBehaviour
{
    public Text scoreText, moneyText, timeText, highScoreText;
    [HideInInspector] public float scoreCount, highScoreCount, moneyCount;

    public GameObject sword;

    private float swordInitialNegativeYPos;
    [HideInInspector] public float scoreBonusValue;

    void Start()
    {
        scoreBonusValue = 0f;

        if (sword.transform.position.y < 0)
        {
            swordInitialNegativeYPos = -sword.transform.position.y;
        }
        else
        {
            swordInitialNegativeYPos = 0;
        }
        if (PlayerPrefs.GetFloat("highScore") > 0)
        {
            highScoreCount = PlayerPrefs.GetFloat("highScore");
        }
        else
        {
            highScoreCount = 0;
        }

        //  moneyCount = PlayerPrefs.GetFloat("MoneyCount");
    }

    void Update()
    {
        if (sword.transform.position.y + swordInitialNegativeYPos + scoreBonusValue >= 0)
        {
            scoreCount = sword.transform.position.y + swordInitialNegativeYPos + scoreBonusValue;


        }
        if (scoreCount > highScoreCount)
        {
            highScoreCount = scoreCount;

            PlayerPrefs.SetFloat("higScore", scoreCount);
        }

        scoreText.text = "S. " + Mathf.Round(scoreCount);
        highScoreText.text = "HS. " + Mathf.Round(highScoreCount);

        timeText.text = "T. " + Time.timeSinceLevelLoad.ToString("F1");/* (Mathf.Round(Time.timeSinceLevelLoad * 10.0f)) / 10.0f;*/

        
        moneyText.text = "$. " + Mathf.Round(moneyCount);

    }
}
