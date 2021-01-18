using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoreController : MonoBehaviour
{
    public Text scoreText, moneyText, timeText, highScoreText;

    [HideInInspector] public float scoreCount, highScoreCount, moneyCount;

    private string sceneName;

    public GameObject sword;

    private float swordInitialNegativeYPos;
    [HideInInspector] public float scoreBonusValue;

    void Start()
    {


        sceneName = SceneManager.GetActiveScene().name;
        scoreBonusValue = 0f;

        if (PlayerPrefs.GetFloat("highScore") > 0)
        {
            highScoreCount = PlayerPrefs.GetFloat("highScore");
        }
        else
        {
            highScoreCount = 0;
        }


        if (sceneName == "Game")
        {

            if (sword.transform.position.y < 0)
            {
                swordInitialNegativeYPos = -sword.transform.position.y;
            }
            else
            {
                swordInitialNegativeYPos = 0;
            }


        }
    }

    void Update()
    {
        if (sceneName == "Game")
        {
            GameScoreController();
        }
        else
        {
            MenuScoreController();
        }

    }

    public void GameScoreController()
    {

        if (sword.transform.position.y + swordInitialNegativeYPos + scoreBonusValue >= 0)
        {
            scoreCount = sword.transform.position.y + swordInitialNegativeYPos + scoreBonusValue;


        }
        if (scoreCount >= highScoreCount)
        {
            highScoreCount = scoreCount;

            PlayerPrefs.SetFloat("highScore", scoreCount);
        }

        scoreText.text = "S. " + Mathf.Round(scoreCount);
        highScoreText.text = "HS. " + Mathf.Round(highScoreCount);

        timeText.text = "T. " + Time.timeSinceLevelLoad.ToString("F1");/* (Mathf.Round(Time.timeSinceLevelLoad * 10.0f)) / 10.0f;*/


        moneyText.text = "$. " + Mathf.Round(moneyCount);
    }
    public void MenuScoreController()
    {

        highScoreText.text = "" + Mathf.Round(highScoreCount);



        //scoreText.text = "S. " + Mathf.Round(scoreCount);

        //  timeText.text = "T. " + Time.timeSinceLevelLoad.ToString("F1");/* (Mathf.Round(Time.timeSinceLevelLoad * 10.0f)) / 10.0f;*/


        //moneyText.text = "$. " + Mathf.Round(moneyCount);
    }

    public void ResetHighScore()
    {
        highScoreCount = 0;

        PlayerPrefs.SetFloat("highScore", highScoreCount);
        highScoreText.text = "" + Mathf.Round(highScoreCount);

    }


}
