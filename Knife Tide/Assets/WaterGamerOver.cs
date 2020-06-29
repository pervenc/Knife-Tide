using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterGamerOver : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject gameController;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Water"))
        {
            gameController.GetComponent<GameController>().gameIsOver = true;
        }
    }
}
