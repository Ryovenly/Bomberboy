using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System.Globalization;
using System;

public class PutBomb : MonoBehaviour
{


    public Rigidbody Bombe;
    public Transform origine;
    public int nbBombes;
    private int Bombes;
    private int firePower;
    private Animator Anim;
    public string player;
    private string controlPutBomb;
    public string[] playerData;
    private string data;

    // Start is called before the first frame update
    void Start()
    {
        Anim = GetComponent<Animator>();
        StartCoroutine(GetData());
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
        if (controlPutBomb != null)
        {
            if (Input.GetKey(controlPutBomb) && Bombes <= nbBombes)
            {
                Anim.SetBool("puttingBomb", true);
                StartCoroutine(waitALittle(Anim.GetCurrentAnimatorStateInfo(0).length));
                Rigidbody instance;
                instance = Instantiate(Bombe, new Vector3(Mathf.RoundToInt(origine.position.x),
                Bombe.transform.position.y, Mathf.RoundToInt(origine.position.z)),
                Bombe.transform.rotation) as Rigidbody;
            }
        }
    }
    IEnumerator GetData()
    {
        UnityWebRequest uwr = UnityWebRequest.Get("http://localhost:8000/getData?player=" + player);
        yield return uwr.SendWebRequest();

        if (uwr.isNetworkError || uwr.isHttpError)
        {
            Debug.Log(uwr.error);
        }
        else
        {
            data = uwr.downloadHandler.text;

            playerData = data.Split('à');

            controlPutBomb = playerData[5];
        }
    }

    IEnumerator waitALittle(float time)
    {
        yield return new WaitForSecondsRealtime(time);
        Anim.SetBool("puttingBomb", false);
    }
}