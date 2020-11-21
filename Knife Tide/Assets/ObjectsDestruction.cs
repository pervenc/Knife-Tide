using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsDestruction : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            Destroy(other.gameObject);
        }
    }
}

