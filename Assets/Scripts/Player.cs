using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{


    public Rigidbody Bombe;
    public Transform origine;
    public int nbBombes;
    private int Bombes;
    public int firePower = 1;
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
 

        // On pose la bombe
            if (Input.GetKeyDown(KeyCode.T) && Bombes <= nbBombes)
        {
            Rigidbody instance;
          instance = Instantiate(Bombe, new Vector3(Mathf.RoundToInt(origine.position.x),
          Bombe.transform.position.y, Mathf.RoundToInt(origine.position.z)),
          Bombe.transform.rotation) as Rigidbody;
        }
    }
}
