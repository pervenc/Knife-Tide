using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{


    public GameObject sword;

    // public float speed = 2.0f;

    public float offset;
    private bool cameraCanFollow = false;

    private void Start()
    {
        cameraCanFollow = true;
    }
    void FixedUpdate()
    {
      //  if (sword.GetComponent<SwordAttack>().gameIsOver == false)
        {
            if (cameraCanFollow /*&& sword.GetComponent<SwordAttack>().grounded == false*/)
            {
                // float interpolation = speed * Time.deltaTime;

                Vector3 position = this.transform.position;
                //  position.y = Mathf.Lerp(this.transform.position.y, sword.transform.position.y + 25, interpolation);
                //this.transform.position = new Vector3(position.x, position.y, position.z);
                this.transform.position = new Vector3(position.x, sword.transform.position.y + offset, position.z);

            }



        }


    }
    void Update()
    {
       // if (transform.position.y <= sword.transform.position.y && !cameraCanFollow && sword.GetComponent<SwordAttack>().grounded == false)
        {
           cameraCanFollow = true;
        }
    }


}
