using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowSomeone : MonoBehaviour
{
    public Transform target;
    public float moveSpeed = 1.0f;
    Rigidbody rb;

    void Start(){
        rb = GetComponent<Rigidbody>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 direction = target.position - transform.position;
        direction = direction.normalized;
        
        Vector3 newVelocity = rb.velocity;
        newVelocity.x = direction.x * moveSpeed;
        newVelocity.z = direction.z * moveSpeed;
        rb.velocity = newVelocity;
        
    }
}