﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombeBonus : MonoBehaviour
{
    private int nbBombeBonus;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        nbBombeBonus = other.GetComponent<Player>().nbBombes;
        other.GetComponent<Player>().nbBombes = nbBombeBonus + 1;
    }
}
