using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinText : MonoBehaviour
{
    public Text winText;
    GameObject winManager;

    // Start is called before the first frame update
    void Start()
    {
        SetTextWinner();
    }

    // Update is called once per frame
    void Update()
    {

    }


    void SetTextWinner()
    {
        winManager = GameObject.Find("Win Manager");
        winText.text = winManager.GetComponent<WinManager>().winner;
        Destroy(GameObject.Find("Win Manager"));
    }
}
