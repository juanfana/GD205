using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cyclops : MonoBehaviour
{
    public float explosionForce = 1f;
    public float explosionRadius = 100f;
    public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       Ray laser = Camera.main.ScreenPointToRay(Input.mousePosition);
       RaycastHit hit = new RaycastHit();

       if (Physics.Raycast(laser, out hit) && Input.GetMouseButton(0)){
            Debug.Log("booyah cyclops sucks?");
            if (hit.rigidbody){ //if the thing we hit has a rigidbody
                //add explosion force to the rigidbody we hit using the variables we created at the point we hit it
                hit.rigidbody.AddExplosionForce(explosionForce, hit.point, explosionRadius);
            }
        }
        
        if (Physics.Raycast(laser, out hit) && Input.GetMouseButton(1)){
            //same thing for the right mouse button, but instead of adding force, we spawn a new prefab
            Instantiate(prefab, hit.point, Quaternion.identity);
        }

    
    }
}
