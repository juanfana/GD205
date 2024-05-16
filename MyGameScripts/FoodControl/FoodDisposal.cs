using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodDisposal : MonoBehaviour
{
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    //Limits created because using physics to drop food items can make them unstable when it comes to positioning, so creating limits of where the object might fall in between can help a more precise deletion of the object.
    {
        if ((FoodControl.EmptyPlateNow>transform.position.x -.9f ) && (FoodControl.EmptyPlateNow < transform.position.x +.9f))
        {
          Destroy(gameObject);
        }
    }
}
