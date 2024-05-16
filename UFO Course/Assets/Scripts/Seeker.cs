using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seeker : MonoBehaviour
{
    Rigidbody rb;
    public Transform target;
    public float forceMultiplier = 2f; 
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
       Vector3 targetOffset = target.position - transform.position; 
       Vector3 targetDirection = Vector3.Normalize(targetOffset);  
       rb.AddForce(targetDirection * forceMultiplier);
    }
}
