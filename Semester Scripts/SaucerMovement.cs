using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaucerMovement : MonoBehaviour
{
   AudioSource Destruction;
    Rigidbody rb;
    public float acc = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Destruction = GetComponent<AudioSource>(); 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
      
       if(Input.GetKey(KeyCode.W))
       {
        Debug.Log("pressed the w key");
        rb.AddForce (0f,0f,acc);
       } 
        if(Input.GetKey(KeyCode.S))
       {
        Debug.Log("pressed the s key");
        rb.AddForce(0f,0f,-acc);
       }  
        if(Input.GetKey(KeyCode.D))
       {
        Debug.Log("pressed the d key");
        rb.AddForce(acc,0f,0f);
       } 
        if(Input.GetKey(KeyCode.A))
       {
        Debug.Log("pressed the a key");
        rb.AddForce(- acc,0f,0f);
       }   
         if(Input.GetKey(KeyCode.Q))
       {
        Debug.Log("pressed the q key");
        rb.AddForce(0f,acc,0f);
       }   
       if(Input.GetKey(KeyCode.E))
       {
        Debug.Log("pressed the e key");
        rb.AddForce(0f,- acc,0f);
       }     
      
    }
}
