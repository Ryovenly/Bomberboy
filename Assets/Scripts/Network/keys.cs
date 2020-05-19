using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Globalization;


public class keys : MonoBehaviour
{
    // Start is called before the first frame update
    private string active = "";
    public Text downText;
    public Text upText;
    public Text leftText;
    public Text rightText;
    public Text dropBombText;
    private string keyString;
    private string actualKey;
    private int majNumber = 0;


    private Hashtable keysHashtable = new Hashtable();

    public KeyCode None { get; private set; }

    private void Start()
    {
        keysHashtable.Add("PageUp", "page up");
        keysHashtable.Add("PageDown", "page down");
        keysHashtable.Add("Quote", "²");
        keysHashtable.Add("CapsLock", "caps lock");
        keysHashtable.Add("ScrollLock", "scroll lock");
        keysHashtable.Add("RightShift", "right shift");
        keysHashtable.Add("LeftShift", "left shift");
        keysHashtable.Add("RightControl", "right ctrl");
        keysHashtable.Add("LeftControl", "left ctrl");
        keysHashtable.Add("RightAlt", "right alt");
        keysHashtable.Add("LeftAlt", "left alt");
        keysHashtable.Add("UpArrow", "up");
        keysHashtable.Add("DownArrow", "down");
        keysHashtable.Add("LeftArrow", "left");
        keysHashtable.Add("RightArrow", "right");
        keysHashtable.Add("Comma", ",");
        keysHashtable.Add("Period", ">");
        keysHashtable.Add("Slash", "/");
        keysHashtable.Add("BackQuote", "'");
        keysHashtable.Add("LeftBracket", "[");
        keysHashtable.Add("RightBracket", "]");
        keysHashtable.Add("Equals", "=");
        keysHashtable.Add("Backslash", "\'");
        keysHashtable.Add("Underscore", "_");
        keysHashtable.Add("Tilde", "~");
        keysHashtable.Add("SysReq", "sys req");
        keysHashtable.Add("[Enter]", "enter");
        keysHashtable.Add("[Minus]", '-');
        keysHashtable.Add("[Divide]", '/');
        keysHashtable.Add("[Multiply]", '*');
        keysHashtable.Add("[Plus]", "+");
    }

    public void changeKeyActive(string activeControl)
    {
        this.active = activeControl;
    }

    public void OnGUI()
    {
        Event e = Event.current;
        if (e.isKey)
        {
            testValueKeyCode(e.keyCode, downText);
            testValueKeyCode(e.keyCode, upText);
            testValueKeyCode(e.keyCode, leftText);
            testValueKeyCode(e.keyCode, rightText);
            testValueKeyCode(e.keyCode, dropBombText);
        }
    }

    private void testValueKeyCode(KeyCode key, Text activeText)
    {
        if (this.active == activeText.name)
        {
            if (key != None)
            {
                keyString = "" + key + "";

                if (keyString.Contains("Alpha"))
                {
                    keyString = keyString.Replace("Alpha", "");
                }

                if (keyString.Contains("Keypad"))
                {
                    keyString = keyString.Replace("Keypad", "[") + "]";
                }

                foreach (DictionaryEntry entry in keysHashtable)
                {
                    if (entry.Key.ToString() == keyString)
                    {
                        keyString = entry.Value.ToString();
                    }
                }

                activeText.text = ("" + keyString + "").ToLower() ;
            }
        }
    }

}
