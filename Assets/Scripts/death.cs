using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class death : MonoBehaviour
{
    private Animator Anim;
    public string LevelToLoad;
    void Start()
    {
        Anim = GetComponent<Animator>();
    }
        private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Explosion" || collider.gameObject.tag == "Fatal")
        {
            Anim.SetBool("diying", true);
            StartCoroutine(StartVictory());
        }
    }

    IEnumerator StartVictory()
    {
        yield return new WaitForSeconds(10f);
        SceneManager.LoadScene(LevelToLoad);
    }

}
