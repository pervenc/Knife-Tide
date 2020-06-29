using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject scoreController;

    [HideInInspector] public bool gameIsOver;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ResetGame();


        GameOver();


    }
    public void GameOver()
    {
        if (gameIsOver)
        {
            SceneManager.LoadScene("MainScene");

            PlayerPrefs.SetFloat("MoneyCount", scoreController.GetComponent<ScoreController>().moneyCount);
        }
    }
    public void ResetGame()
    {

        if (Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene("MainScene");

            PlayerPrefs.SetFloat("MoneyCount", scoreController.GetComponent<ScoreController>().moneyCount);

        }
    }
}
