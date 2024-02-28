using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineStop : MonoBehaviour
{
    

   [SerializeField ] List<GameObject> tower=new List<GameObject> ();

   
    void OnCollisionEnter(Collision other)
    {
       if(other.gameObject .CompareTag ("Player"))
        {
            foreach (GameObject tower in tower) 
            {
                tower.GetComponent<SpawnEnemy>().enabled = true;
            }
          
            other.gameObject.GetComponent<PlayerController>().SetMoveForward = false;

            other.gameObject.GetComponent<PlayerController>().SetMoveSide = true;

            other.gameObject.GetComponent<SpawnObject>().enabled = true;
        }
        else if (other.gameObject.CompareTag("Enemy"))
        {
           LevelManager.Instance .GameOver();
           
;        }
    }
}
