using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class investigarPuerta : MonoBehaviour
{
    public float distanciaMinima = 25f;
    public Transform jugador;
    public stateController estado;
    public inventario inventario;
    private AudioSource audio;
    void Start()
    {
        audio = GetComponent<AudioSource>();
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
                if(inventario.llaveAzul)
                {
                    AbrirPuertaAzul();
                }
                if(inventario.llaveVerde)
                {
                    AbrirPuertaVerde();
                }
                if(inventario.llaveFinal)
                {
                    AbrirPuertaFinal();
                }
                else
                {
                    audio.Play();
                }
            }
        }
    }
    void AbrirPuertaAzul()
    {
        inventario.usedBlueKey = true;
    }
    void AbrirPuertaVerde()
    {
        inventario.usedGreenKey = true;
    }
    void AbrirPuertaFinal()
    {
        inventario.usedFinalKey = true;
    }
}
