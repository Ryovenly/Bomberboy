using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using System.Globalization;
using System;

public class Move : MonoBehaviour
{
    private Animator Anim;
    public Vector3 translation;
    public Vector3 rotation;
    private string up;
    private string down;
    private string left;
    private string right;
    public string[] playerData;
    public string player;
    private string data;

    void Start()
    {
        Anim = GetComponent<Animator>();
        translation.z = 8f;
        rotation.y = 280f;
        StartCoroutine(GetData());
    }

    private void Update()
    {
   
        Anim.SetBool("running", false);

        if (!Anim.GetBool("diying") && !Anim.GetBool("puttingBomb") && up != null)
        {
            if (Input.GetKey(up))
            {
                Anim.SetBool("running", true);
                transform.Translate(translation * Time.deltaTime);
            }
            if (Input.GetKey(down))
            {
                Anim.SetBool("running", true);
                transform.Translate(-translation * Time.deltaTime);
            }
            if (Input.GetKey(right))
            {
                transform.Rotate(rotation * Time.deltaTime);
            }
            if (Input.GetKey(left))
            {
                transform.Rotate(-rotation * Time.deltaTime);
            }
        }
    }
    // Update is called once per frame

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

            down = playerData[1];
            up = playerData[2];
            left = playerData[3];
            right = playerData[4];
        }
    }
}
