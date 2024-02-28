using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] float speed2 = 10;
    [SerializeField] float xRange;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }

    void FixedUpdate()
    { 
        if (rb.velocity.magnitude < 6)
        {
            rb.AddForce(Vector3.back * speed2 * 10, ForceMode.Acceleration);
        }
        //transform.Translate(Vector3.back* Time.deltaTime * speed);
        //float xPos= Random.Range(xRange, (xRange - 1));
        //float xPoss = Random.Range(-xRange, (-xRange + 1));

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
    }
}
