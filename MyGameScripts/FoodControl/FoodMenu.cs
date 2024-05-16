using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMenu : MonoBehaviour
{
    public GameObject cloneObj;
    public int foodValue;
     public GameObject plate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        FoodControl.createdMenuItem += foodValue;

        if(gameObject.name!= "1000")
           Instantiate(cloneObj, plate.transform.position, cloneObj.transform.rotation);
    
    }
}
