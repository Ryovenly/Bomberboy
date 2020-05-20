using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Web;
using UnityEngine.Networking;

public class InputControl : MonoBehaviour
{
    public Text downText;
    public Text upText;
    public Text leftText;
    public Text rightText;
    public Text dropBombText;
    public Text player;

    public void startControl()
    {
        StartCoroutine(Upload());
    }

    IEnumerator Upload()
    {
        Debug.Log((upText.text).ToLower());
        WWWForm form = new WWWForm();

        UnityWebRequest www = UnityWebRequest.Post("http://localhost:8001/sendData?player=" + (player.text).ToLower() + "&upControl=" + (upText.text).ToLower() + "&downControl=" + (downText.text).ToLower() + "&leftControl=" + (leftText.text).ToLower() + "&rightControl=" + (rightText.text).ToLower() + "&dropControl=" + (dropBombText.text).ToLower(), form);
        yield return www.SendWebRequest();

        if (www.isNetworkError || www.isHttpError)
        {
            Debug.Log(www.error);
        }
        else
        {
            Debug.Log("Form upload complete!");
        }
    }
}
