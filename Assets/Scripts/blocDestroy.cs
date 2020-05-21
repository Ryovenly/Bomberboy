using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blocDestroy : MonoBehaviour
{
    // private int randomNumber = Random.Range(0, 2);
    public bool isDestroy = false;
    public List<Rigidbody> bonusMalus = new List<Rigidbody>();
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    public void GenerateBonusAndMalus()
    {
        for (int i = 0; i < bonusMalus.Count; i++)
        {
            Rigidbody temp = bonusMalus[i];
            int randomIndex = Random.Range(i, bonusMalus.Count);
            bonusMalus[i] = bonusMalus[randomIndex];
            bonusMalus[randomIndex] = temp;
        }

            Rigidbody instance;
            instance = Instantiate(bonusMalus[1], rb.position, rb.rotation) as Rigidbody;
        }

    private void Update()
    {
        if(isDestroy == true)
        {
            Debug.Log("c détruit");
            GenerateBonusAndMalus();
            Destroy(gameObject);
        }
    }

}
