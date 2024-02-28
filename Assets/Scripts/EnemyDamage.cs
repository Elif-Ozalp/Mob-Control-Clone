using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    bool control = true;
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Stickman") && control )
        {
            other.gameObject.GetComponent<Health>().setHealth = other.gameObject.GetComponent<Health>().hEalth - 1;
            gameObject.GetComponent<Health>().setHealth = gameObject.GetComponent<Health>().hEalth - 1;
            control = false;
        }
    }
}
