using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreController : MonoBehaviour
{
    public Text scoreText, moneyText;
    [HideInInspector] public float scoreCount, moneyCount;

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

        //  moneyCount = PlayerPrefs.GetFloat("MoneyCount");
    }

    void Update()
    {
        if (sword.transform.position.y + swordInitialNegativeYPos + scoreBonusValue >= 0)
        {
            scoreCount = sword.transform.position.y + swordInitialNegativeYPos + scoreBonusValue;

          
        }

        scoreText.text = "S." + Mathf.Round(scoreCount);
        moneyText.text = "$." + Mathf.Round(moneyCount);

    }
}
