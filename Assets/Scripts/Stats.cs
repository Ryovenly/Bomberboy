﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour
{
    public int firePower = 2;
    public int bomb = 2;
    public string Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            firePower++;
        }
        Debug.Log("feu stat" + firePower);

        MinimumStats();
    }

    private void MinimumStats()
    {
        if (firePower < 3)
        {
            firePower = 3;
        }

        if (bomb < 1)
        {
            bomb = 1;
        }
    }
}
