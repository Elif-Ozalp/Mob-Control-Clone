using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateMovement : MonoBehaviour
{
    [SerializeField] float speed = 2f;
    [SerializeField] float xPRange = 7f;
    [SerializeField] float xNRange = 7f;


    // Update is called once per frame
    void Update()
    {


       

        transform.Translate(Vector3.right * Time.deltaTime * speed);
        if (transform.position.x < xNRange)
        {
            speed = -speed;

        }
        else if (transform.position.x > xPRange)
        {

            speed = -speed;

        }









    }
}
