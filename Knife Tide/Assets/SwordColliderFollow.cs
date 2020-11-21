using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordColliderFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject swordObject, actualSword
        ;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(actualSword.transform.position.x, actualSword.transform.position.y, actualSword.transform.position.z);

    }

    public void OnTriggerEnter2D(Collider2D other)
    {

        swordObject.GetComponent<SwordAttack>().theTriggered = other.gameObject;

        if (other.CompareTag("Wall"))
        {
            swordObject.GetComponent<SwordAttack>().TriggerSimulator("Wall");

        }
        else if (other.CompareTag("Sky"))
        {
            swordObject.GetComponent<SwordAttack>().TriggerSimulator("Sky");

        }
        else if (other.CompareTag("ColliderEnabler"))
        {
            swordObject.GetComponent<SwordAttack>().TriggerSimulator("ColliderEnabler");

        }

    }
}
