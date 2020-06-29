using UnityEngine;
using System.Collections;

public class ArrowMovement : MonoBehaviour
{

    public float arrowSpeed;
    public GameObject swordObject;

    private int arrowAngle;
    void Update()
    {
        if (swordObject.GetComponent<SwordAttack>().grounded)
        {
            float angle = Mathf.PingPong(Time.time * arrowSpeed, 70) - 70;

            if (transform.position.x > 0)
            {
                arrowAngle = 0;
            }
            else
            {
                arrowAngle = 180;
            }
            this.transform.rotation = Quaternion.Euler(0, arrowAngle, angle);
            gameObject.GetComponent<SpriteRenderer>().enabled = true;

        }
        else
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}