using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
     void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Stickman") || other.gameObject.CompareTag("Stickman2"))
        {
            other.gameObject.SetActive(false);
        }
    }


}
