using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallVerticalFall : MonoBehaviour
{
    public GameObject sword;
    private GameObject theGameController;

    private float thresholdPosition;

    void Start()
    {
        thresholdPosition = 50;
        sword = GameObject.FindGameObjectWithTag("Sword");

        theGameController = GameObject.FindGameObjectWithTag("TheGameController");
    }

    // Update is called once per frame
    void Update()
    {
        if (!GameController.gameIsPaused)
        {

            if (sword.transform.position.y > thresholdPosition)
            {
                thresholdPosition += sword.transform.position.y;

            }
        }
        // Debug.Log(gameObject.GetComponent<Rigidbody2D>().velocity);
    }
    private void FixedUpdate()
    {

        if (!GameController.gameIsPaused)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector3(0, -1f - (thresholdPosition * 0.005f), 0);
        }



    }
}
