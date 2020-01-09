using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    public Rigidbody Bombe;
    public Transform origine;
    public int nbBombes;
    private int Bombes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Bombes = GameObject.FindGameObjectsWithTag("bombe").Length;

        // Déplacement du personnage

        if (Input.GetKey(KeyCode.I))
        {
            transform.Translate(0.1f, 0, 0);

        }
        if (Input.GetKey(KeyCode.J))
        {
            transform.Translate(0, 0, 0.1f);
        }
        if (Input.GetKey(KeyCode.K))
        {
            transform.Translate(-0.1f, 0, 0);
        }
        if (Input.GetKey(KeyCode.L))
        {
            transform.Translate(0, 0, -0.1f);
        }
 


            if (Input.GetKeyDown(KeyCode.T) && Bombes <= nbBombes)
        {
            Rigidbody instance;
          instance = Instantiate(Bombe, origine.position, origine.rotation) as Rigidbody;
        }
    }
}
