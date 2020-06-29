using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsGenerator : MonoBehaviour
{

    public GameObject sword, apple, goldCoin, silverCoin;
    private GameObject finalItem;
    private float randomYValue, whichItem;
    private Vector3 updatePosition;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MoveGenerator", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y - sword.transform.position.y < 60)
        {
            MoveGenerator();

        }
    }

    void MoveGenerator()
    {
        if (Random.Range(0, 100) < 40)
        {
            whichItem = Random.Range(0, 100);

            if (whichItem <= 60)
            {
                finalItem = apple;

            }
            else if (whichItem <= 90)
            {
                finalItem = silverCoin;

            }
            else
            {
                finalItem = goldCoin;
            }
            randomYValue = Random.Range(-5f, 6f);
            Instantiate(finalItem, new Vector3(transform.position.x + Random.Range(-6f, 6f), transform.position.y + randomYValue, transform.position.z), Quaternion.identity);



            updatePosition = new Vector3(transform.position.x, transform.position.y + 20, transform.position.z);

            transform.position = updatePosition;
        }


    }
}
