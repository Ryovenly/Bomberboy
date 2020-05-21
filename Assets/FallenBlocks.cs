using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenBlocks : MonoBehaviour
{
    private Collider collider;
    private bool grounded;
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<Collider>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("ground"))
        {
            collider.isTrigger = false;
        }
    }


}
