using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningSwordEffects : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject swordEffects;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SwordEffectsOn()
    {
        swordEffects.SetActive(true);
    }
    public void SwordEffectsOff()
    {
        swordEffects.SetActive(false);

    }
}
