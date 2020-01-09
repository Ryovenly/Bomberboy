using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    public Rigidbody Bombe;
    public Transform origine;
    public int nbBombes;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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
 


            if (Input.GetKey(KeyCode.T) && GameObject.Find("Bombe(Clone)") == null)
        {
            Rigidbody instance;
          instance = Instantiate(Bombe, origine.position, origine.rotation) as Rigidbody;
        }
    }
}
