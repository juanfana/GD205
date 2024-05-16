using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CookMeat : MonoBehaviour
{
    public GameObject Pan;
    public Transform cloneObj;
    public int foodValue;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   public void OnMouseDown()
    {
        if(gameObject.name == "Beef")
        Instantiate(cloneObj, Pan.transform.position , cloneObj.rotation);

        if(gameObject.name == "Leg")
        Instantiate(cloneObj, Pan.transform.position + new Vector3(0f,.1f,0f), cloneObj.rotation);

    }
}
