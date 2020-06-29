using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallGenerator : MonoBehaviour
{

    public GameObject sword, wall;
    private float randomYValue;
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

    void SpawnWall()
    {

    }
    void MoveGenerator()
    {
        randomYValue = Random.Range(-5f, 6f);
        Instantiate(wall, new Vector3(transform.position.x + 11.5f, transform.position.y + randomYValue, transform.position.z), Quaternion.Euler(0, 0, 90));

        randomYValue = Random.Range(-5f, 6f);
        Instantiate(wall, new Vector3(transform.position.x - 11.5f, transform.position.y + randomYValue, transform.position.z), Quaternion.Euler(0, 180, 90));

        updatePosition = new Vector3(transform.position.x, transform.position.y + 20, transform.position.z);

        transform.position = updatePosition;

    }
}
