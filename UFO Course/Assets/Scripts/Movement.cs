using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.W))
       {
        Debug.Log("pressed the w key");
        transform.position += new Vector3(0f,0f,1f);
       } 
        if(Input.GetKeyDown(KeyCode.S))
       {
        Debug.Log("pressed the s key");
        transform.position += new Vector3(0f,0f,- 1f);
       }  
        if(Input.GetKeyDown(KeyCode.D))
       {
        Debug.Log("pressed the d key");
        transform.position += new Vector3(1f,0f,0f);
       } 
        if(Input.GetKeyDown(KeyCode.A))
       {
        Debug.Log("pressed the a key");
        transform.position += new Vector3(- 1f,0f,0f);
       }   
       if(Input.GetKeyDown(KeyCode.Q))
       {
        Debug.Log("pressed the q key");
        transform.position += new Vector3(0f,1f,0f);
       }   
       if(Input.GetKeyDown(KeyCode.E))
       {
        Debug.Log("pressed the e key");
        transform.position += new Vector3(0f,- 1f,0f);
       }     
       
    }
}
