using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinishLevel : MonoBehaviour
{
    [SerializeField]  List<GameObject> level1 = new List<GameObject>();
    [SerializeField]  List<GameObject> level2 = new List<GameObject>();
    [SerializeField]  List<GameObject> level3 = new List<GameObject>();
    [SerializeField] GameObject tower1;
    [SerializeField] GameObject tower2;
    [SerializeField] GameObject tower3;
    [SerializeField] GameObject tower4;
    [SerializeField] GameObject player;
    bool control = true;
    bool control2 = true;
    bool control3 = true;
    bool check = true;
    bool check2 = true;
    bool check3 = true;

   





    GameObject[] stickman = new GameObject[100];
    GameObject[] enemy = new GameObject[100];
    
    void Update()
    {
        

        if (tower1.GetComponent<Health>().hEalth <= 0)
        {
            if(check)
            {
                ObjectPool.Instance.PutToPool();
                ObjectPool2.Instance.PutToPool2();
                EnemyPool.Instance.PutToPool3();
                InstantiatePool.Instance.PutToPool();
                check = false;

            }
            

            //destroy the level object
            StartCoroutine(destroyLevel(level1));

           


            if (control)
            {
                StartParticle(level1);
                LevelManager.Instance.FinishRound();
                player.GetComponent<SpawnObject>().enabled = false;
                player.GetComponent<PlayerController>().SetMoveForward = true;
                player.GetComponent<PlayerController>().SetMoveSide = false;
              
                control = false;
            }
            
            
        }
        if (tower2.GetComponent<Health>().hEalth <= 0)
        {
            if (check2)
            {
                ObjectPool.Instance.PutToPool();
                ObjectPool2.Instance.PutToPool2();
                EnemyPool.Instance.PutToPool3();
                InstantiatePool.Instance.PutToPool();
                check2 = false;

            }
            
            StartCoroutine(destroyLevel(level2));


           
            if (control2)
            {
                StartParticle(level2);
                LevelManager.Instance.FinishRound();
                player.GetComponent<SpawnObject>().enabled = false;
                player.GetComponent<PlayerController>().SetMoveForward = true;
                player.GetComponent<PlayerController>().SetMoveSide = false;
             
                control2 = false;
            }
        }
        if (tower3.GetComponent<Health>().hEalth <= 0 && tower4.GetComponent<Health>().hEalth <= 0)
        {
            if(check3)
            {
                ObjectPool.Instance.PutToPool();
                ObjectPool2.Instance.PutToPool2();
                EnemyPool.Instance.PutToPool3();
                InstantiatePool.Instance.PutToPool();
                check3 = false;

            }

            StartCoroutine(destroyLevel(level3));

          




            if (control3)
              {
                StartParticle(level3);
                LevelManager.Instance.FinishRound();
                player.GetComponent<SpawnObject>().enabled = false;
                player.GetComponent<PlayerController>().SetMoveForward = true;
                player.GetComponent<PlayerController>().SetMoveSide = false;
                
                control3 = false;
              }
            StartCoroutine(finishLevel());
        } 
    }
    IEnumerator finishLevel()
    {
        yield return new WaitForSeconds(4.5f);
        LevelManager.Instance.FinishGame();
        LevelManager.Instance.UpdateScoreFinal();


    }
    IEnumerator destroyLevel(List<GameObject> listLevel)
    {
        yield return new WaitForSeconds(0.2f);
        for (int i = 0; i < listLevel.Count; i++)
        {
           
            listLevel[i].SetActive(false);

        }
  
    }

    void StartParticle(List<GameObject> listParticle)
    {
        for (int i = 0; i < listParticle.Count; i++)
        {
            Vector3 particlePos = listParticle [i].transform.position;
            particlePos.z += 1;
            GameObject gg = ParticlePool3.Instance.GetFromPool().gameObject;
            gg.SetActive(true);
            gg.transform.position = particlePos;
            StartCoroutine(PutToPool());
         
        }

    }
   
    IEnumerator PutToPool()
    {
        yield return new WaitForSeconds(2f);
        ParticlePool3.Instance.PutToPool();
    }
   
}




