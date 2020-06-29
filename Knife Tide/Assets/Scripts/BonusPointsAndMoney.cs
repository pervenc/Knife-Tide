using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusPointsAndMoney : MonoBehaviour
{

    [HideInInspector] public int minBonusValue, maxBonusValue;
    private int bonusValue;

    public AudioSource coinSound, pointsSound;

    private GameObject scoreController;
    void Start()
    {

        scoreController = GameObject.Find("ScoreController");
      //  bonusValue = Mathf.CeilToInt( PlayerPrefs.GetFloat("MoneyCount"));

    }

    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Money"))
        {
            other.gameObject.GetComponent<CircleCollider2D>().enabled = false;
            other.gameObject.GetComponent<Animator>().SetTrigger("CoinTaken");
            coinSound.Play();
           minBonusValue = other.GetComponent<BonusValues>().minMoneyValue;
            maxBonusValue = other.GetComponent<BonusValues>().maxMoneyValue;
       


            bonusValue += Random.Range(minBonusValue, maxBonusValue);
           // bonusValue += 10;

            scoreController.GetComponent<ScoreController>().moneyCount = bonusValue;
        }
        else if (other.CompareTag("Points"))

        {

            other.gameObject.GetComponent<CircleCollider2D>().enabled = false;
            other.gameObject.GetComponent<Animator>().SetTrigger("PointsTaken");
            pointsSound.Play();
            minBonusValue = other.GetComponent<BonusValues>().minPointsValue;
            maxBonusValue = other.GetComponent<BonusValues>().maxPointsValue;


            bonusValue += Random.Range(minBonusValue, maxBonusValue);
            scoreController.GetComponent<ScoreController>().scoreBonusValue = bonusValue;
        }

    }
}
