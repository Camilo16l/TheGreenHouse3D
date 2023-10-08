using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public bool isMoving = false;
    private  Rigidbody rb;
    public int velocidad = 5;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        HandleInput();
    }

    private void HandleInput()
    {

        Vector3 newDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
            {
                newDirection = Vector3.forward;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                newDirection = Vector3.back;
            }

        if (Input.GetKey(KeyCode.D))
            {
                newDirection += Vector3.right;
            }
        else if (Input.GetKey(KeyCode.A))
            {
                newDirection += Vector3.left;
            }

        if (newDirection != Vector3.zero)
            {
                isMoving = true;
                transform.forward = newDirection.normalized;
                rb.velocity = newDirection.normalized * velocidad;
            }

        else
            {
                isMoving = false;
                rb.velocity = Vector3.zero;
            }
            

    }
}
