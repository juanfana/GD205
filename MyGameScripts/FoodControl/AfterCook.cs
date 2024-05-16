using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Made mistake during the naming process of this script but this is in reality the "while cooking"
public class AfterCook : MonoBehaviour
{
//Declaring variables for control and verification of cooking time,having the string check if its been removed to early from the pan or cooking device
    private int foodValue=0;
    public MeshRenderer meatMat;
    public string StillCooking = "y";
    // Start is called before the first frame update
    void Start()
    //Initializing a mesh renderer for "cooking" effect, opening a coroutine to apply pauses for "cooking" time and serving time
    {
        meatMat = GetComponent<MeshRenderer>();
        StartCoroutine(cookTimer());
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnMouseDown()
    {
     
       GetComponent<Transform>().position = new Vector3(FoodControl.plateXpos, .66f, 0);
       FoodControl.plateValue[FoodControl.plateNum] += foodValue;
       StillCooking = "n";
    }
    IEnumerator cookTimer()
    //function created to emulate cooking process with timer and color change to indicate item is cooked, 
    {
       yield return new WaitForSeconds(10);
       foodValue = 1000;
       if (StillCooking == "y")
       meatMat.material.color = new Color (.3f,.3f,.3f);

    }
}
