using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombeMalus : MonoBehaviour
{

    private int nbBombeMalus;

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
        nbBombeMalus = other.GetComponent<Player>().nbBombes;
        other.GetComponent<Player>().nbBombes = nbBombeMalus - 1;
    }

}
