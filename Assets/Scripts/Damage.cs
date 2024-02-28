using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Damage : MonoBehaviour
{
    int coin = 0;
    public int GetCoin { get { return coin; } } 

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Tower"))
        {
            if (gameObject.CompareTag("Stickman"))
            {
                LevelManager.Instance.UpdateCoinFinal(10);
                Vector3 particlePos = other.transform.position;
                particlePos.y += 6f;
                particlePos.z += 1;
                other.gameObject.GetComponent<Health>().setHealth = other.gameObject.GetComponent<Health>().hEalth - 1;
                gameObject.GetComponent<Health>().setHealth = gameObject.GetComponent<Health>().hEalth - 1;

                GameObject gg = ParticlePool.Instance.GetFromPool().gameObject;
                gg.SetActive(true);
                gg.transform.position = particlePos;
                StartCoroutine(PuttToPool());


                LevelManager.Instance.UpdateScore(10);


            }
            else if (gameObject.CompareTag("Stickman2"))
            {
                LevelManager.Instance.UpdateCoinFinal(20);
                Vector3 particlePos = other.transform.position;
                particlePos.y += 6f;
                particlePos.z += 1;
                other.gameObject.GetComponent<Health>().setHealth = other.gameObject.GetComponent<Health>().hEalth - 3;
                gameObject.GetComponent<Health>().setHealth = gameObject.GetComponent<Health>().hEalth - 1;

                GameObject gg = ParticlePool.Instance.GetFromPool().gameObject;
                gg.SetActive(true);
                gg.transform.position = particlePos;
                StartCoroutine(PuttToPool());

                LevelManager.Instance.UpdateScore(10);
            }

        }
        else if (other.gameObject.CompareTag("Enemy"))
        {
            if (gameObject.CompareTag("Stickman"))
            {
                Vector3 particlePos = other.transform.position;
                other.gameObject.GetComponent<Health>().setHealth = other.gameObject.GetComponent<Health>().hEalth - 1;
                gameObject.GetComponent<Health>().setHealth = gameObject.GetComponent<Health>().hEalth - 1;

                GameObject gg = ParticlePool2.Instance.GetFromPool().gameObject;
                gg.SetActive(true);
                gg.transform.position = particlePos;

                StartCoroutine(PuttToPool2());

                LevelManager.Instance.UpdateScore(10);


            }
            else if (gameObject.CompareTag("Stickman2"))
            {
                Vector3 particlePos = other.transform.position;
                other.gameObject.GetComponent<Health>().setHealth = other.gameObject.GetComponent<Health>().hEalth - 3;
                gameObject.GetComponent<Health>().setHealth = gameObject.GetComponent<Health>().hEalth - 1;

                GameObject gg = ParticlePool2.Instance.GetFromPool().gameObject;
                gg.SetActive(true);
                gg.transform.position = particlePos;
                StartCoroutine(PuttToPool2());


                LevelManager.Instance.UpdateScore(10);
            }
        }
        else if (other.gameObject.CompareTag("Wall"))
        {
            if (gameObject.CompareTag("Stickman"))
            {

                other.gameObject.GetComponent<Health>().setHealth = other.gameObject.GetComponent<Health>().hEalth - 1;
                gameObject.GetComponent<Health>().setHealth = gameObject.GetComponent<Health>().hEalth - 1;


                LevelManager.Instance.UpdateScore(10);



            }
            else if (gameObject.CompareTag("Stickman2"))
            {

                other.gameObject.GetComponent<Health>().setHealth = other.gameObject.GetComponent<Health>().hEalth - 3;
                gameObject.GetComponent<Health>().setHealth = gameObject.GetComponent<Health>().hEalth - 1;



                LevelManager.Instance.UpdateScore(10);
            }
        }
    }

    IEnumerator PuttToPool()
    {
        yield return new WaitForSeconds(2f);
        ParticlePool.Instance.PutToPool();
    }
    IEnumerator PuttToPool2()
    {
        yield return new WaitForSeconds(1f);
        ParticlePool2.Instance.PutToPool();
    }
}
