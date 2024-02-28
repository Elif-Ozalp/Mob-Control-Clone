using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Health : MonoBehaviour
{
   // [SerializeField ]TextMeshPro label;
    [SerializeField ] private  float health ;
    public float hEalth { get { return health; } }
    public float setHealth { set { health = value; } }
    
    




    void Update()
    {
        if (health <= 0)
        {

            gameObject.SetActive(false);


        }
    }


    
}
