using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// On sépare le collider de la bombe en le mettant enfant pour utiliser la méthode transform.Find

public class Bombe : MonoBehaviour
{
    public GameObject Player;
    public GameObject explosionPrefab;

    public LayerMask levelMask;
    //  Le LayerMask permet de stopper l'explosion. On attribue ainsi un lawyer Wall ( qui fonctionne comme un tag) sur tous les blocs murs 

    private bool exploded = false;
    private float timeBomb = 3f;
    public int firePower;

    // Use this for initialization
    void Start()
    {
        Invoke("Explode", timeBomb); // Invoque la fonction Explode qui se termine selon timeBomb
    }


    void Update()
    {

        Debug.Log("feu bombe" + firePower);
    }

    void Explode()
    {

        //  On crée une première explosion qui sera le centre de l'explosion
        Instantiate(explosionPrefab, transform.position, Quaternion.identity);

        //  On instancie sur les chaques côtés une explosion
        StartCoroutine(CreateExplosions(Vector3.forward));
        StartCoroutine(CreateExplosions(Vector3.right));
        StartCoroutine(CreateExplosions(Vector3.back));
        StartCoroutine(CreateExplosions(Vector3.left));

        GetComponent<MeshRenderer>().enabled = false; // On enlève le Mesh
        exploded = true;
        transform.Find("Collider").gameObject.SetActive(false); //  On enlève le collider qui est l'enfant de la bombe
        Destroy(gameObject, timeBomb); //   On détruit la bombe
    }

    public void OnTriggerEnter(Collider other)
    {
        if (!exploded && other.CompareTag("Explosion"))
        { //  Si la bombe n'a pas encore explosé et qu'il rencontre une explosion on va chercher à faire exploser la bombe  
            CancelInvoke("Explode"); // On annule là l'ancienne fonction Explode pour ne pas que ça explose deux fois
            Explode(); //   On fait exploser la bombe directement
        }
    }

    private IEnumerator CreateExplosions(Vector3 direction)
    {
        for (int i = 1; i < firePower; i++)
        { 
            //  Le raycast va essayer de rentrer en contact avec la distance i qui sera au maximum à firePower qui sera la limite du raycast et de la puissance de feu
            RaycastHit hit;
            Ray ray = new Ray(transform.position, transform.forward);

            Physics.Raycast(transform.position + new Vector3(0, .5f, 0), direction, out hit, i, levelMask, QueryTriggerInteraction.Ignore); //  Fonction du Raycast, il ne pourra toucher que le LayerMask levelMask (Wall)

            if (!hit.collider)
            { // Il n'y a pas de mur donc l'explosion se propage  
                Debug.DrawLine(ray.origin, hit.point, Color.red);
                Instantiate(explosionPrefab, transform.position + (i * direction), explosionPrefab.transform.rotation);
            }
            else
            { //  On touche un mur donc l'explosion s'arrête
                Debug.DrawLine(ray.origin, hit.point, Color.red);
                if (hit.collider.gameObject.CompareTag("destroyable"))
                {
                    Destroy(hit.collider.gameObject);
                }
                break;
            }

            yield return new WaitForSeconds(.05f);
        }

    }
}
