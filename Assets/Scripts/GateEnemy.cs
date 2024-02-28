using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateEnemy : MonoBehaviour
{
   
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Stickman") || other.gameObject.CompareTag("Stickman2"))
        {
            other.gameObject.GetComponent<Health>().setHealth = other.gameObject.GetComponent<Health>().hEalth - 1;
           
            
        }
       
    }
}
