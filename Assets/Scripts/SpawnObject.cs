using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnObject : MonoBehaviour
{
    List<GameObject> spawnObject = new List<GameObject>();
    int counter = 0;
    public EnergyBar energyBar;
    [SerializeField] Transform parent;
    [SerializeField] Transform bulge;
    bool bulgee = false;
  
    void Update()
    {
        energyBar.SetEnergy(counter);
        if (bulgee)
        {
            Vector3 pos = new Vector3(-0.0369f, 0, 0);
            bulge.Translate(Vector3.forward * Time.deltaTime * 35);
            StartCoroutine(GoBack(pos));
        }
        
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            counter++;

            bulgee = true;
            if (counter <= 10)
            {
                GameObject aa = InstantiatePool.Instance.GetFromPool().gameObject;
                aa.SetActive(true);
                Vector3 pos1 = transform.position;
                pos1.y += 1; ;
                pos1.z += 7;
                aa.transform.position = pos1;
                StartCoroutine(SpawnObjectt(1));
               
               
            }
                
            
            else if (counter == 11)
            {
                GameObject aa = InstantiatePool.Instance.GetFromPool().gameObject;
                aa.SetActive(true);
                Vector3 pos1 = transform.position;
                pos1.y += 1; ;
                pos1.z += 7;
                aa.transform.position = pos1;
                StartCoroutine(SpawnObjectt(2));

               

            }


        }
    }
    IEnumerator PutToPool(GameObject pp)
    {

        yield return new WaitForSeconds(0.5f);
        pp.transform.SetParent(parent);
        PowerPool.Instance.PutToPool();
    }

    IEnumerator GoBack(Vector3 pos)
    {
        yield return new WaitForSeconds(0.15f);
        bulge.localPosition =pos;
        bulgee = false;
    }
    IEnumerator SpawnObjectt(int a)
    {
        yield return new WaitForSeconds(0.4f);
        if (a == 1)
        {

            GameObject gg = ObjectPool.Instance.GetFromPool().gameObject;
            gg.SetActive(true);
            spawnObject.Add(gg);
            Vector3 pos = transform.position;
            pos.z += 2;
            gg.transform.position = pos;
       
        }

        else if (a == 2)
        {
            GameObject pp = PowerPool.Instance.GetFromPool().gameObject;
            pp.SetActive(true);
            Vector3 poss = transform.position;
            poss.y += 3;
            pp.transform.position = poss;
            pp.transform.SetParent(transform);
            StartCoroutine(PutToPool(pp));
           

           


            GameObject gg = ObjectPool2.Instance.GetFromPool().gameObject;
            gg.SetActive(true);
            spawnObject.Add(gg);
            Vector3 pos = transform.position;
            pos.z += 2;
            gg.transform.position = pos;
          //  InstantiatePool.Instance.PutToPool();

            counter = 0;
        }
        
    }
}  
