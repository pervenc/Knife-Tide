﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackOutController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject blackOutImage;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void BlackOutAndPlayGame()
    {
        blackOutImage.SetActive(true);
    }
}