﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutBomb : MonoBehaviour
{


    public Rigidbody Bombe;
    public Transform origine;
    public int nbBombes;
    private int Bombes;
    private int firePower;
    public UnityEngine.KeyCode putBomb;
    private Animator Anim;

    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        firePower = gameObject.GetComponent<Stats>().firePower;
        nbBombes = gameObject.GetComponent<Stats>().bomb;

        Bombes = GameObject.FindGameObjectsWithTag("bombe").Length;

        if (Anim.GetBool("puttingBomb"))
        {
            StartCoroutine(waitALittle(Anim.GetCurrentAnimatorStateInfo(0).length));
        }
        else
        {
            Anim.SetBool("puttingBomb", false);
        }

        // On pose la bombe
        if (Input.GetKeyDown(putBomb) && gameObject.GetComponent<PutBomb>() && Bombes <= nbBombes)
        {
            Anim.SetBool("puttingBomb", true);
            StartCoroutine(waitALittle(Anim.GetCurrentAnimatorStateInfo(0).length));
            Rigidbody instance;
            instance = Instantiate(Bombe, new Vector3(Mathf.RoundToInt(origine.position.x),
            Bombe.transform.position.y-0.5f, Mathf.RoundToInt(origine.position.z)),
            Bombe.transform.rotation) as Rigidbody;
            instance.GetComponent<Bombe>().firePower = firePower;
        }
    }

    IEnumerator waitALittle(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        Anim.SetBool("puttingBomb", false);
    }
}