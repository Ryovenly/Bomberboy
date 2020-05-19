using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class changeScenePlayer : MonoBehaviour
{
    public string LevelToLoad;
    private int numberOfPlayers = 2;
    private int actualPlayersControls = 1;
    public Text player;

    public void LoadLevel()
    {
        if (numberOfPlayers > actualPlayersControls)
        {
            actualPlayersControls++;
            player.text = "bomberboy" + actualPlayersControls;
        }
        else
        {
            SceneManager.LoadScene(LevelToLoad);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
