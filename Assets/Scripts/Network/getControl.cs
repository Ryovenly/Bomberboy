using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class getControl : MonoBehaviour
{
    public Text downText;
    public Text upText;
    public Text leftText;
    public Text rightText;
    public Text dropBombText;
    public Text player;
    private string data;
    public string[] playerData;

    public void Start()
    {
        StartCoroutine(GetData());
    }

    IEnumerator GetData()
    {
        UnityWebRequest uwr = UnityWebRequest.Get("http://localhost:8000/getData?player=" + player.text);
        yield return uwr.SendWebRequest();

        Debug.Log(player.text);

        if (uwr.isNetworkError || uwr.isHttpError)
        {
            Debug.Log(uwr.error);
        }
        else
        {
            data = uwr.downloadHandler.text;

            playerData = data.Split('à');

            downText.text = playerData[1];
            upText.text = playerData[2];
            leftText.text = playerData[3];
            rightText.text = playerData[4];
            dropBombText.text = playerData[5];
        }
    }
}
