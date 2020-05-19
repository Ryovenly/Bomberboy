using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMalus : MonoBehaviour
{
    public Rigidbody Player;
    private int fireBonus;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        fireBonus = Player.GetComponent<Player>().firePower;
        Player.GetComponent<Player>().firePower = fireBonus - 1;
    }
}
