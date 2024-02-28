using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{

    [SerializeField] int spawnCount;
    void Start()
    {
        
            StartCoroutine(Spawn());
            

    }




    IEnumerator Spawn()
    {
        GameObject[] gg = new GameObject[100];
        for(int j = 0; j < spawnCount ; j++) 
        {
            for (int i = 0; i < 15; i++)
            {
                float posX = Random.Range(-3, 3);
                gg[i] = EnemyPool.Instance.GetFromPool().gameObject;
                Vector3 pos = transform.position;
                pos.z -= 5;
                pos.x += posX;
                gg[i].transform.position = pos;
                gg[i].transform.rotation = transform.rotation;
                gg[i].SetActive(true);


                yield return new WaitForSeconds(0.1f);
            }
            yield return new WaitForSeconds(5f);
        }
       
            
        
        
        
        
    }
}
