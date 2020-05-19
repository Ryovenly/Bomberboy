using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBonus : MonoBehaviour
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
        if (other.gameObject.CompareTag("Player"))
        fireBonus = Player.GetComponent<Player>().firePower;
        Player.GetComponent<Player>().firePower = fireBonus + 1;
    }
}
