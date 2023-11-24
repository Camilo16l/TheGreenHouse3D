using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraTeletransporte : MonoBehaviour
{
    public destinoCamara.destinos destination;
    public Camera camara;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Verifica si el objeto es la cámara
        {
            // Accede a destinoCamara para obtener la posición de destino
            Vector3 teleportPosition = FindObjectOfType<destinoCamara>().destination[destination];
            // Teletransporta la cámara a la posición de destino
            camara.transform.position = teleportPosition;
        }
    }
}
