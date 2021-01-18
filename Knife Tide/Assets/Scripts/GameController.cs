using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject scoreController;

    [HideInInspector] public bool gameIsOver;

    public static bool gameIsPaused;
    public GameObject gameMenu, scoreAndButton, fadeMenu;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        gameIsPaused = false;
        ResetGame();


        GameOver();

        //  Debug.Log(gameIsPaused);

    }
    public void GameOver()
    {
        if (gameIsOver)
        {
            SceneManager.LoadScene("Game");

            PlayerPrefs.SetFloat("MoneyCount", scoreController.GetComponent<ScoreController>().moneyCount);
        }
    }
    public void ResetGame()
    {

        if (Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene("Game");

            PlayerPrefs.SetFloat("MoneyCount", scoreController.GetComponent<ScoreController>().moneyCount);

        }
    }

    public void ButtonTest()
    {

        SceneManager.LoadScene("Game");

    }

    public void ExitGame()
    {
        Debug.Log("QUIT GAME");

        Application.Quit();

    }



    public void MainMenuFadeOn()
    {
        fadeMenu.GetComponent<Animator>().Play("FadeMenuOn");

    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");

    }

    public void MenuOnButton()
    {
        gameIsPaused = true;
        Debug.Log(gameIsPaused);
        gameMenu.GetComponent<Animator>().Play("MenuOn");
        scoreAndButton.GetComponent<Animator>().Play("ScoreOut");
        fadeMenu.GetComponent<Animator>().Play("FadeMenuOn");


    }
    public void MenuOffButton()
    {
        gameIsPaused = false;
        gameMenu.GetComponent<Animator>().Play("MenuOff");
        scoreAndButton.GetComponent<Animator>().Play("ScoreIn");
        fadeMenu.GetComponent<Animator>().Play("FadeMenuOff");


    }

    public void PauseGame()
    {
        if (Time.timeScale > 0)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
