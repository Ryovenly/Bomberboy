using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EasterEgg : MonoBehaviour
{
    int i=0;
    public GameObject[] fallenBlocks;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(FallenBlock());
    }

 

        IEnumerator FallenBlock()
    {
        if (GameObject.FindWithTag("destroyable") == null)
        {
            GameObject[] fallens;
            Rigidbody rb;


            fallens = GameObject.FindGameObjectsWithTag("fallen");

            foreach (GameObject fallen in fallens)
            {
                rb = fallen.GetComponent<Rigidbody>();
                rb.isKinematic = false;
                yield return new WaitForSeconds(1f);
            }

        }

    }


}
