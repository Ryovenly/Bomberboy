using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
    private Animator Anim;
    public string LevelToLoad;
    public string playerName;
    public WinManager winManager;
    private int dead = 0;


    void Start()
    {
        Anim = GetComponent<Animator>();
    }
        private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Explosion" || collider.gameObject.tag == "Fatal" || collider.gameObject.tag == "fallen")
        {
            dead++;
            if (dead == 1)
            {
                winManager.PlayerDied(playerName);
                Anim.SetBool("diying", true);
                StartCoroutine(StartVictory());
            }

        }
    }

    IEnumerator StartVictory()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(LevelToLoad);
    }

}
