using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hazard1 : MonoBehaviour 
{
    public Transform Coconut;
    public Transform [] Coconuts;
    
    Vector3 startpos;

    // Start is called before the first frame update
    void Start()
    {
       startpos = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
      for(int i =0; i < Coconuts.Length; i++){
     if(transform.position == Coconuts[i].position){
        Debug.Log("ouchh!");
        transform.position = startpos;
     }
      }
    }
}
