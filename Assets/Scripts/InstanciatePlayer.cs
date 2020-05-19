using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanciatePlayer : MonoBehaviour
{

    public Transform Player;
    public Transform spot;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Player, spot.position, spot.rotation);
    }


    // Update is called once per frame
    void Update()
    {

    }
}
