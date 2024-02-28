using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PrintHealth : MonoBehaviour
{
    [SerializeField] TextMeshPro label;
    Health health;
    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<Health>();
        label.GetComponent<TextMeshPro>();
        label.text = health.hEalth.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(health.hEalth > 0)
        {
            label.text = health.hEalth.ToString();
        }
        else
        {
            label.text = "0";
        }
        
    }
}
