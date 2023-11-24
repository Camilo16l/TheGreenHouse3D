using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float raycastDistance = 5f;
    public movimiento salud;
    public float attackDistance = 2f;
    public float speed = 2f;
    void Start()
    {
        
    }

    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
       Debug.DrawRay(ray.origin, ray.direction * raycastDistance, Color.yellow);

        if (Physics.Raycast(ray, out hit, raycastDistance))
        {
            if (hit.collider.CompareTag("Player"))
            {
                Golpe();
            }
        }        
    }
    
    void Golpe()
    {
        salud.salud--;
        if (salud.salud == 0)
        {
            salud.muerto = true;
        }
    }
}


