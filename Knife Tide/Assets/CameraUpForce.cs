using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraUpForce : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * 5, ForceMode2D.Impulse);

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CameraUpForceFunction()
    {

        gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * 55, ForceMode2D.Impulse);

    }

}
