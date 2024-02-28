using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpawnObject : MonoBehaviour
{
     private float speed ;
    private bool slippery = false;
   
    public bool getSlippery { get { return slippery; } }
    public bool setSlippery { set { slippery = value; } }

    private bool toSide = false;

    public bool GetToSide { get { return toSide; } }
    public bool SetToSide { set { toSide  = value; } }

    [SerializeField] float xRange;
    Rigidbody rb;
 
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        speed = 125;
      
            rb.AddForce(Vector3.forward * speed * 10, ForceMode.Acceleration);
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        speed = 30;
        if (!slippery)
        {
            
            //transform.Translate(Vector3.forward * Time.deltaTime * speed);
            if (rb.velocity.magnitude < 6)
            {
                rb.AddForce(Vector3.forward * speed * 10, ForceMode.Acceleration);
            }
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
    void Update()
    {
        speed = 30;
        if (slippery)
        {

            Vector3 targetPos = new Vector3(-3, 0, 90);
            Vector3 targetPos1 = new Vector3(0, 0, 190);
            Vector3 targetPos2 = new Vector3(8, 0, 288);

            if (targetPos.z > transform.position.z)

            {
                transform.position = Vector3.Lerp(transform.position, targetPos, 0.5f * Time.deltaTime);


            }
            else if (targetPos1.z > transform.position.z)
            {

                transform.position = Vector3.Lerp(transform.position, targetPos1, 0.5f * Time.deltaTime);
            }
            else if (targetPos2.z > transform.position.z)
            {

                transform.position = Vector3.Lerp(transform.position, targetPos2, 0.5f * Time.deltaTime);
            }


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
}
