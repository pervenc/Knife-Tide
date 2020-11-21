using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStarter : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject mainCamera, mainMenu, theGame;
    private Animator anim;
    private string sceneName;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        sceneName = SceneManager.GetActiveScene().name;


        if (sceneName == "Game")
        {
            anim.Play("BlackOff");

        }
        else
        {
            anim.Play("BlackOut");

        }
    }

    // Update is called once per frame
    void Update()
    {


    }

    public void BlackOutToGame()
    {

        SceneManager.LoadScene("Game");
    }

    public void TurningItselfOff()
    {
        this.gameObject.SetActive(false);
    }

}
