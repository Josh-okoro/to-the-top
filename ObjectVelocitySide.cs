using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectVelocitySide : MonoBehaviour
{
    // Axis of object force, check Inspector
    [SerializeField]
    Vector3 objectForce;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // Object in scene movement
        GetComponent<Rigidbody>().velocity += objectForce;
    }
    
}
