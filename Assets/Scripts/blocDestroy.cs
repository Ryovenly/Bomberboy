using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blocDestroy : MonoBehaviour
{
    // private int randomNumber = Random.Range(0, 2);

    void Start()
    {

    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Explosion")
        {
            GenerateBonusAndMalus();
            Destroy(gameObject);
        }
    }

    public void GenerateBonusAndMalus()
    {
        
    }
}
