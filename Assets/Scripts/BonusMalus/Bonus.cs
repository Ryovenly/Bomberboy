using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Bonus : MonoBehaviour
{

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "bomberman")
        {
            GetBonus(collider);
        }
    }

    public void GetBonus(Collider bomberman)
    {

    }






    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
