using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cyclops : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
       RaycastHit hit = new RaycastHit();

       if (Physics.Raycast(laser, out hit)){
        Debug.Log("booyah cyclops sucks?");
       } 
    }
}
