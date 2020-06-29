using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CameraFollow2 : MonoBehaviour
{
    public Transform target;
    public GameObject sword, swordFollowPoint;

    public float levelStartPos = -12f;
    public float levelEndPos = 185f;


    private float smoothDampTime = 0.15f;
    private Vector3 smoothDampVelocity = Vector3.zero;

    private float camWidth, camHeight, levelMinY, levelMaxY;

    void Start()
    {
        camHeight = Camera.main.orthographicSize * 2;
        camWidth = camHeight * Camera.main.aspect;

        // float leftBoundsWidth = leftBounds.GetComponentInChildren<SpriteRenderer>().bounds.size.x / 2;
        // float rightBoundsWidth = rightBounds.GetComponentInChildren<SpriteRenderer>().bounds.size.x / 2;
        //levelMinX = leftBounds.position.x + (camWidth / 2);
        // levelMaxX = rightBounds.position.x - (camWidth / 2);

        ///acima é pra quando tiver um background e quiser limitar a camera pelo tamanho do background


        levelMinY = levelStartPos + (camWidth / 2);
        levelMaxY = levelEndPos - (camWidth / 2);





    }

    void FixedUpdate()
    {


        /* if (target && sword.GetComponent<SwordAttack>().grounded == false && this.transform.position.y < target.position.y)
        {
            float targetY = Mathf.Max(levelMinY, Mathf.Min(levelMaxY, target.position.y));
            float y = Mathf.SmoothDamp(transform.position.y, targetY, ref smoothDampVelocity.y, smoothDampTime);
            transform.position = new Vector3(transform.position.x, y, transform.position.z);
        
        }*/





    }

    private void Update()
    {
        if (sword.GetComponent<SwordAttack>().grounded == false && this.transform.position.y < target.position.y)
        {
            Vector3 position = this.transform.position;
            this.transform.position = new Vector3(position.x, swordFollowPoint.transform.position.y, position.z);
        }
    }

}
