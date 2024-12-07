using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float Speed;
    Rigidbody rb;
    [SerializeField] private float jumpForce;
    bool midJump = false;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        Jump();
    }
    void FixedUpdate()
    {
        Vector3 movement = Vector3.forward * Speed;
        movement.y = rb.velocity.y;
        rb.velocity = movement;
    }

    void Jump()
    {
        // player jumps along y axis
        if (Input.GetKeyDown(KeyCode.Space) && (midJump == false))
        {
            rb.velocity = Vector3.up * jumpForce;
            midJump = true;
        }
        if (rb.velocity.y == 0)
        {
            midJump = false;
        }
    }
}
