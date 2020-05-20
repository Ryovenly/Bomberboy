using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinManager : MonoBehaviour
{

    public List<GameObject> Players = new List<GameObject>();

    private int deadPlayers = 0;
    private string deadPlayerName;
    public string winner;


    private void Update()
    {
        Debug.Log(deadPlayers);
    }

    public void PlayerDied(string playerName)
    {
        deadPlayers++;

        if (deadPlayers == 1)
        {
            deadPlayerName = playerName;
            Invoke("CheckPlayersDeath", 2.0f);
        }
    }

    void CheckPlayersDeath()
    {
        if (deadPlayers == 1)
        { //Single dead player, he's the winner

            if (deadPlayerName == "bomberboy1")
            { //P1 dead, P2 is the winner
                Debug.Log("Bomberboy 2 a gagné !");
                winner = "Bomberboy 2 a gagné !";
                DontDestroyOnLoad(transform.gameObject);
            }
            else if (deadPlayerName == "bomberboy2")
            { //P2 dead, P1 is the winner
                Debug.Log("Bomberboy 1 a gagné !");
                winner = "Bomberboy 1 a gagné !";
                DontDestroyOnLoad(transform.gameObject);
            }
        }
        else if (deadPlayers == 4) // petit bug quand la personne ne sort pas du trigger de la bombe instancié
        {
            if (deadPlayerName == "bomberboy1")
            { //P1 dead, P2 is the winner
                Debug.Log("Bomberboy 2 a gagné !");
                winner = "Bomberboy 2 a gagné !";
                DontDestroyOnLoad(transform.gameObject);
            }
            else if (deadPlayerName == "bomberboy2")
            { //P2 dead, P1 is the winner
                Debug.Log("Bomberboy 1 a gagné !");
                winner = "Bomberboy 1 a gagné !";
                DontDestroyOnLoad(transform.gameObject);
            }
        }
        else
        {
            Debug.Log("Tout le monde est mort dommage !");
            winner = "Tout le monde est mort dommage !";
            DontDestroyOnLoad(transform.gameObject);
        }
    }
}
