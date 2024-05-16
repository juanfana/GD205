using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hazard : MonoBehaviour
{
    public Transform Cactus;
    public Transform[]Cactuses;

    Vector3 startpos;

    // Start is called before the first frame update
    void Start()
    {
        startpos = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        for(int i =0; i < Cactuses.Length; i++){
     if(transform.position == Cactuses[i].position){
        Debug.Log("ouchh!");
        transform.position = startpos;
     }
      }
    }
}
