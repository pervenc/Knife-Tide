using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterRising : MonoBehaviour

{
    private Rigidbody2D rb;

    private float waterRisingForce, distanceBetweenSW;

    public GameObject sword;
    public Transform waterReferencePoint, cameraPosition;

    private bool outOfScreen;

    private GameObject theGameController;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        theGameController = GameObject.FindGameObjectWithTag("TheGameController");


    }

    // Update is called once per frame
    void Update()
    {
        if (!GameController.gameIsPaused)
        {

            distanceBetweenSW = Mathf.Abs(sword.transform.position.y - waterReferencePoint.transform.position.y);

            if (cameraPosition.position.y - waterReferencePoint.position.y >= 26)
            {
                outOfScreen = true;
            }
            else
            {
                outOfScreen = false;
            }


            if (outOfScreen)
            {
                waterRisingForce = 50;
                //waterRisingForce = Mathf.Pow(distanceBetweenSW, 2);
                //transform.position = new Vector3(transform.position.x, camera.transform.position.y - 16, transform.position.z);
            }
            else if (distanceBetweenSW >= 13)
            {
                waterRisingForce = distanceBetweenSW / 6;
                //  waterRisingForce = 2;


            }
            else if (distanceBetweenSW >= 6)

            {
                waterRisingForce = distanceBetweenSW / 9;
                // waterRisingForce = 1;
            }
            else
            {
                //waterRisingForce = distanceBetweenSW / 16;
                waterRisingForce = distanceBetweenSW / 15;


            }

        }




    }

    private void FixedUpdate()
    {
        if (!GameController.gameIsPaused)
        {

            rb.velocity = new Vector2(rb.velocity.x, waterRisingForce);
        }
    }

}
