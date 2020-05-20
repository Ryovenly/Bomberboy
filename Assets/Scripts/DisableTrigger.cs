using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Script permettant au joueur de pouvoir bouger dans la bombe jusqu'à qu'il sort


public class DisableTrigger : MonoBehaviour
{

        public void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("bomberboy"))
            { 
                GetComponent<Collider>().isTrigger = false; // Disable the trigger
            }
        }

}
