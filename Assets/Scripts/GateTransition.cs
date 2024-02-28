using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateTransition : MonoBehaviour
{
    
    List<GameObject> stickman = new List<GameObject>();
    public List<GameObject> GetStickman { get { return stickman; } }
    void OnTriggerEnter(Collider other)
    {
      
      
           if (other.gameObject.CompareTag("Stickman") && !stickman.Contains(other.gameObject))
            {
            GameObject aa = InstantiatePool.Instance.GetFromPool().gameObject;
            aa.SetActive(true);
            Vector3 pos1 = other.transform.position;
            pos1.y += 1;
            aa.transform.position = pos1;

            stickman.Add(other.gameObject);
                GameObject gg = ObjectPool.Instance.GetFromPool().gameObject;
                stickman.Add(gg);
                gg.SetActive(true);
                gg.transform.position = other.transform.position;
              

            }
            else if (other.gameObject.CompareTag("Stickman2") && !stickman.Contains(other.gameObject))
            {
            GameObject aa = InstantiatePool.Instance.GetFromPool().gameObject;
            aa.SetActive(true);
            Vector3 pos1 = other.transform.position;
            pos1.y += 1;
            aa.transform.position = pos1;
            stickman.Add(other.gameObject);
                GameObject gg = ObjectPool2.Instance.GetFromPool().gameObject;
                stickman.Add(gg);
                gg.SetActive(true);
                gg.transform.position = other.transform.position;
               

            }


        
    }
    
}
