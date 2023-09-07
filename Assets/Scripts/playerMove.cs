using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    public float velocidad;
    public int tile;
    private Vector3 targetPosition;
    public bool isMoving = false;
    private Rigidbody rb;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        if (!isMoving)
        {
            HandleInput();
        }
    }

        public void HandleInput()
    {

        Vector3 moveDirection = Vector3.zero;

        if (Input.GetKey(KeyCode.W))
        {
            moveDirection = Vector3.forward;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            moveDirection = Vector3.back;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            moveDirection = Vector3.left;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            moveDirection = Vector3.right;
        }

        if (moveDirection != Vector3.zero)
        {
            RotateAndMove(moveDirection);
        }
        
    }


    private void RotateAndMove(Vector3 direction)
    {
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = targetRotation;

        Vector3 newPosition = transform.position + direction * tile;

        if (IsValidMove(newPosition))
        {
            targetPosition = newPosition;
            isMoving = true;
        }
    }

    private bool IsValidMove(Vector3 position)
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, position - transform.position, out hit, tile))
        {
            if (hit.collider != null && !hit.collider.isTrigger)
            {
                return false; // There is an obstacle in the way.
            }
        }
        return true;
    }

    private void FixedUpdate()
    {
        if (isMoving)
        {
             transform.position = Vector3.Lerp(transform.position, targetPosition, velocidad * Time.fixedDeltaTime);
            
            if (Vector3.Distance(transform.position, targetPosition) < 0.05f)
            {
                transform.position = targetPosition;
                isMoving = false;
            }
        }
    }
}
