using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float Speed;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        Vector3 movement = Vector3.forward * Speed;
        movement.y = rb.velocity.y;
        rb.velocity = movement;
    }
}
