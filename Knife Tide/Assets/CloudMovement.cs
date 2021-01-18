using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D rb;
    public float leftRightForce;

    public bool moveToLeft, isStartingCloud;
    void Start()
    {
        if (moveToLeft)
        {
            leftRightForce = -1;

        }
        else
        {
            leftRightForce = 1;

        }
        if (isStartingCloud)
        {
            transform.position = new Vector3(transform.position.x - Random.Range(5f, -5f), transform.position.y - Random.Range(5f, -5f), transform.position.z);
        }


        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Round(transform.position.x) > 60)
        {
            leftRightForce = leftRightForce * -1;
        }

    }
    private void FixedUpdate()
    {
        rb.velocity = new Vector2(leftRightForce, rb.velocity.y);

    }
}
