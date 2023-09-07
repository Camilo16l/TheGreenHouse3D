using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personaje : MonoBehaviour
{
public GameObject personajeObj;
public Animator animator;
public float targetRotationY = 0f; // Almacena la última rotación
public bool moving = false;
    void Start()
    {

    }

    void Update()
    {
        if (personajeObj != null)
        {

            Vector3 newPosition = new Vector3(personajeObj.transform.position.x, transform.position.y, personajeObj.transform.position.z);
            transform.position = newPosition;

            bool isMoving = false;
            
            if (Input.GetKey(KeyCode.W))
            {
                targetRotationY = 0f;
                isMoving = true;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                targetRotationY = 90f;
                isMoving = true;
            }
            else if (Input.GetKey(KeyCode.S))
            {
                targetRotationY = 180f;
                isMoving = true;
            }
            else if (Input.GetKey(KeyCode.A))
            {
                targetRotationY = -90f;
                isMoving = true;
            }

            moving = isMoving;
            animator.SetBool("movimiento", isMoving);
            
            Vector3 newRotation = transform.eulerAngles;
            newRotation.y = targetRotationY;
            transform.eulerAngles = newRotation;

        
        }

    }
    
}
