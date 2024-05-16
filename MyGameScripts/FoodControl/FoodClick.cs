using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodClick : MonoBehaviour
{
    public Transform cloneObj;

    public GameObject tray;
    
    public int foodValue;
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
      if (gameObject.name== "Burger")
      Instantiate(cloneObj, tray.transform.position + new Vector3(FoodControl.plateXpos,.10f,0), cloneObj.rotation);

      if (gameObject.name== "Eyeball")
      Instantiate(cloneObj, tray.transform.position + new Vector3(FoodControl.plateXpos,.10f,0), cloneObj.rotation);
      
      if (gameObject.name== "Tower Sandwich")
      {
      Instantiate(cloneObj, tray.transform.position + new Vector3(FoodControl.plateXpos,.10f,0), cloneObj.rotation);
      }
    

        FoodControl.plateValue[FoodControl.plateNum] += foodValue;
        
        Debug.Log(FoodControl.plateValue[FoodControl.plateNum]+"  "+FoodControl.orderValue[FoodControl.plateNum]);

    }
}
