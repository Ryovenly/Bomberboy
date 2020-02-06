using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blocDestroy : MonoBehaviour
{
    public Rigidbody Bombe;
    private Rigidbody instance;

    void Start()
    {

    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Explosion")
        {
            Destroy(gameObject);
        }
    }
}
