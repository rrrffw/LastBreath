﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oxygen_Tracker_test : MonoBehaviour
{
    [SerializeField] public int oxytrack;
    float timepassed = 0.0f;
    int seconds = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timepassed += Time.deltaTime*5;
        seconds = (int)timepassed;

        if (seconds>0){
            oxytrack -= seconds;
            seconds = 0;
            timepassed = 0.0f;
        }
    }
}
