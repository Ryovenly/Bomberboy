using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Animator Anim;
    public Vector3 translation;
    public Vector3 rotation;
    public UnityEngine.KeyCode up;
    public UnityEngine.KeyCode down;
    public UnityEngine.KeyCode left;
    public UnityEngine.KeyCode right;

    void Start()
    {
        Anim = GetComponent<Animator>();
        translation.z = 8f;
        rotation.y = 280f;
    }

    // Update is called once per frame
    void Update()
    {
        // Déplacement du personnage

        Anim.SetBool("running", false);

        if (!Anim.GetBool("diying") && !Anim.GetBool("puttingBomb"))
        {
            if (Input.GetKey(up))
            {
                Anim.SetBool("running", true);
                transform.Translate(translation * Time.deltaTime);
            }
            if (Input.GetKey(down))
            {
                Anim.SetBool("running", true);
                transform.Translate(-translation * Time.deltaTime);
            }
            if (Input.GetKey(right))
            {
                transform.Rotate(rotation * Time.deltaTime);
            }
            if (Input.GetKey(left))
            {
                transform.Rotate(-rotation * Time.deltaTime);
            }
        }

    }
}
