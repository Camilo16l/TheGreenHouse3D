using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class investigar : MonoBehaviour
{
    public float distanciaMinima = 25f;
    public Transform jugador;
    public bool investigado;
    public stateController estado;
    
    void Start()
    {
        investigado = false;
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !estado.atacando)
        {
            float distanciaJugador = Vector3.Distance(transform.position, jugador.position);
            Vector3 direccionMirada = jugador.forward;
            Ray ray = new Ray(jugador.position, direccionMirada);
            Debug.DrawLine(jugador.position, jugador.position + direccionMirada * distanciaMinima, Color.red, 0.1f);

            RaycastHit hit;
            if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject && distanciaJugador <= distanciaMinima)
            {
                if (!investigado)
                {
                    Investigar();
                }
            }
        }
        

    }
    
    void Investigar()
    {
        if(!investigado)
        {
            Debug.Log("Investigando...");
            investigado = true;
        }
    }
}
