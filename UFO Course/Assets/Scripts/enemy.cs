using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    Rigidbody rigidbody;
    public Transform target; 
    public float forceMultiplier = 2f;
    // Start is called before the first frame update
    void Start()
    {
     rigidbody = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
      Vector3 targetDistance = target.position - transform.position;
      Vector3 targetDirection = Vector3.Normalize(targetDistance);
      rigidbody.AddForce(targetDirection*forceMultiplier);
    }
}
