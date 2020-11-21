using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowController : MonoBehaviour
{
    // Start is called before the first frame update
    [HideInInspector] public bool canFollow;

    public GameObject sword;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (((sword.transform.position.y) > transform.position.y) && sword.transform.position.y > 0)
        {
            Vector3 position = this.transform.position;

            transform.position = new Vector3(position.x, sword.transform.position.y, position.y);
            canFollow = true;
        }
        else
        {
            canFollow = false;
        }



    }

    private void FixedUpdate()
    {

    }
}
