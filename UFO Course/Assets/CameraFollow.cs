using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Vector3 offSet = new Vector3(0f,0f,-10f);
    public float SmoothTime = 0.25f;
    public Vector3 velocity = Vector3.zero;

    [SerializeField] public Transform  target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetposition = target.position + offSet;
        transform.position = Vector3.SmoothDamp(transform.position, targetposition, ref velocity, SmoothTime);
    }
}
