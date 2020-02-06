using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutBomb : MonoBehaviour
{


    public Rigidbody Bombe;
    public Transform origine;
    public int nbBombes = 2;
    private int Bombes;
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
        if (Input.GetKeyDown(putBomb) && Bombes <= nbBombes)
        {
            Anim.SetBool("puttingBomb", true);
            StartCoroutine(waitALittle(Anim.GetCurrentAnimatorStateInfo(0).length));
            Rigidbody instance;
            instance = Instantiate(Bombe, new Vector3(Mathf.RoundToInt(origine.position.x),
            Bombe.transform.position.y, Mathf.RoundToInt(origine.position.z)),
            Bombe.transform.rotation) as Rigidbody;
        }
    }

    IEnumerator waitALittle(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        Anim.SetBool("puttingBomb", false);
    }
}