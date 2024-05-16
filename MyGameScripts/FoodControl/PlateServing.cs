using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateServing : MonoBehaviour
{
    public int WhichPlate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

//Function created to check if the order was correctly served. Debug log added to make sure timer was working
 public void OnMouseDown ()
 {
    if(FoodControl.orderValue[FoodControl.plateNum]== FoodControl.plateValue[FoodControl.plateNum])
    {
        Debug.Log("Correct"+""+FoodControl.OrderTimer[FoodControl.plateNum]);
    }
//This has the new value for empty plates move along the X axis to the according plate then a Coroutine is started to give it some time to delete everything on the plate
    FoodControl.EmptyPlateNow = transform.position.x;
    StartCoroutine(platereset());
 }
//Indicator of deletion time and then set back value to inidicate nothing else is going to be deleted. line 36 adds tip depending on the remaining time 
 IEnumerator platereset()
 {
    yield return new WaitForSeconds(.2f);
    FoodControl.EmptyPlateNow = -1;
    FoodControl.TotalCash += FoodControl.OrderTimer[WhichPlate] * .10f;
 }
}

