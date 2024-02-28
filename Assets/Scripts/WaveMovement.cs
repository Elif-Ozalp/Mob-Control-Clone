using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveMovement : MonoBehaviour
{
   /* [SerializeField] GameObject[] waypoints;
    int current = 0;
    float rotSpeed;
    [SerializeField] float speed;
    float wPradius=1;*/
  
    void Update()
    {
        /* if(Vector3.Distance(waypoints[current ].transform.position ,transform.position )<wPradius)
         {
             current++;
             if(current >=waypoints.Length)
             {
                 current = 0;
             }
         }
         transform.position = Vector3.MoveTowards(transform.position, waypoints[current].transform.position, Time.deltaTime * speed);*/
        float x = transform.position.x;
        float y = transform.position.y;
        float z = Mathf.Sin(Time.time*2f);
        transform.position = new Vector3(x, y, z);
       
    }
}
