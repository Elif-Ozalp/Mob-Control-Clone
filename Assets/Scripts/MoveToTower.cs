using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTower : MonoBehaviour
{
    

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Stickman")  && gameObject.CompareTag("Obstacle"))
        {
            StartCoroutine(makeTrue(other.gameObject, 1));
        }
        else if (other.gameObject.CompareTag("Stickman2") && gameObject.CompareTag("Obstacle"))
        {
            StartCoroutine(makeTrue(other.gameObject, 3));
        }
        if (other.gameObject.CompareTag("Stickman") && gameObject.CompareTag("ToTower"))
        {
            MakeTrue(other.gameObject);
        }
        else if (other.gameObject.CompareTag("Stickman2") && gameObject.CompareTag("ToTower"))
        {
            MakeTrue(other.gameObject);
        }
    }


    IEnumerator makeTrue(GameObject other,float waitingTime)
    {
        yield return new WaitForSeconds(waitingTime );
        MakeTrue(other);

      
    }

    void MakeTrue(GameObject other)
    {
       
        other.GetComponent<MoveSpawnObject>().setSlippery = true;
      
       
    }
}
