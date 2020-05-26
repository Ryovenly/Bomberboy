﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMalus : MonoBehaviour
{
    private int fireBonus;

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
        if (other.gameObject.CompareTag("bomberboy"))
        {
            other.GetComponent<Stats>().firePower -= 1;
            Destroy(gameObject);
        }

        if (other.gameObject.tag == "Explosion" || other.gameObject.tag == "Fatal" || other.gameObject.tag == "fallen")
        {
            Destroy(gameObject);
        }
    }
}
