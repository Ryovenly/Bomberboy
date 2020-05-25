using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TelepBH : MonoBehaviour
{
    public Vector3 teleportationTranslation;
    public SphereCollider OtherBlackHole;
    public Vector3 scaleObjetTouch;
    public Vector3 positionObjetTouch;
    public float sizeChangeSpeed;

    // Start is called before the first frame update
    void Start()
    {
        teleportationTranslation.x = 1000f;
        sizeChangeSpeed = 0.02f;
    }

    public void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("bomberboy"))
        {
            scaleObjetTouch = collider.transform.localScale;
            positionObjetTouch = collider.transform.localPosition;
            StartCoroutine(teleport(collider.transform, sizeChangeSpeed));
        }

    }

    IEnumerator teleport(Transform target,float changeSpeed)
    {

        for (int i = 0; target.localScale.x > 0.1; i++)
        {
            ComeCloser(target);
            target.localScale -= new Vector3(changeSpeed, changeSpeed, changeSpeed);
            yield return new WaitForSeconds(0.001f);
        }

        OtherBlackHole.enabled = false;

        target.transform.position = new Vector3(OtherBlackHole.transform.position.x, positionObjetTouch.y, OtherBlackHole.transform.position.z) ;;

        for (int i = 0; target.localScale.x < scaleObjetTouch.x; i++)
        {
            target.localScale += new Vector3(changeSpeed, changeSpeed, changeSpeed);
            yield return new WaitForSeconds(0.001f);
        }

        yield return new WaitForSeconds(1.4f);

        OtherBlackHole.enabled = true;
    }

    public void ComeCloser(Transform target)
    {
        if (target.transform.position.x < transform.position.x)
        {
            target.transform.position = new Vector3(target.transform.position.x + 0.1f, target.transform.position.y, target.transform.position.z);
        }
        if (target.transform.position.x > transform.position.x)
        {
            target.transform.position = new Vector3(target.transform.position.x - 0.1f, target.transform.position.y, target.transform.position.z);
        }
        if (target.transform.position.y < transform.position.y)
        {
            target.transform.position = new Vector3(target.transform.position.x + 0.1f, target.transform.position.y, target.transform.position.z);
        }
        if (target.transform.position.y < transform.position.y)
        {
            target.transform.position = new Vector3(target.transform.position.x - 0.1f, target.transform.position.y, target.transform.position.z);
        }
    }
}
