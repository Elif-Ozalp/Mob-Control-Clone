using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController: MonoBehaviour
{
    
    [SerializeField] private float speed = 10f;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float xRange = 9.5f;
    [SerializeField] Slider slider;

    private bool moveForward = true;
    public bool GetMoveForward { get { return moveForward; } }
    public bool SetMoveForward { set { moveForward = value; } }


    private bool moveSide = true;
    public bool GetMoveSide { get { return moveSide; } }
    public bool SetMoveSide { set { moveSide = value; } }

    
    void Update()
    {
        Vector3 pos = transform.position;
        pos.x -= 3.5f;
        pos.y += 2f;
       
        slider.transform.position = Camera.main.WorldToScreenPoint(pos);
     
        horizontalInput = Input.GetAxis("Horizontal");

        if (moveForward == true)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
       
        if(moveSide == true)
        {
            transform.Translate(Vector3.right * Time.deltaTime * horizontalInput * speed);
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