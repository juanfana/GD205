using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hazard : MonoBehaviour
{
    public Transform Cat;
    public Transform[]Cats;

    Vector3 startpos;

    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        for(int i =0; i < Cats.Length; i++){
     if(transform.position == Cats[i].position){
        Debug.Log("ouchh!");
        transform.position = startpos;
     }
      }
    }
}
