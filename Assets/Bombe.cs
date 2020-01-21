using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bombe : MonoBehaviour
{

    public LayerMask Wall;

    public GameObject Explosion;
    // Start is called before the first frame update
    void Start()
    {
            Invoke("Explode", 3f);

    }

    // Update is called once per frame

    void Explode()
    {
        Instantiate(Explosion, transform.position, Quaternion.identity);

        StartCoroutine(CreateExplosions(Vector3.forward));
        StartCoroutine(CreateExplosions(Vector3.right));
        StartCoroutine(CreateExplosions(Vector3.back));
        StartCoroutine(CreateExplosions(Vector3.left));

        GetComponent<MeshRenderer>().enabled = false; 
        transform.Find("Collider").gameObject.SetActive(false);

    }


    void Update()
    {
        Destroy(gameObject, 3f);
    }




    private IEnumerator CreateExplosions(Vector3 direction)
    {

        for (int i = 1; i < 5; i++)
        {

            RaycastHit hit;
            
            Physics.Raycast(transform.position + new Vector3(0, 5f, 0), direction, out hit,
              i);

            
            if (!hit.collider)
            {
                Instantiate(Explosion, transform.position + (i * direction),

                  Explosion.transform.rotation);
               
            }
            else
            {
                break;
            }

            yield return new WaitForSeconds(.05f);
        }

    }
}