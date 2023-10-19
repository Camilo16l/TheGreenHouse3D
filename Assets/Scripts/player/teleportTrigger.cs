using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class teleportTrigger : MonoBehaviour
{
    public teletransporte.destinos destination;
    public Image overlay;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Accede al Teletransporte para obtener la posición de destino
            Vector3 teleportPosition = FindObjectOfType<teletransporte>().destination[destination];
            // Teletransporta al jugador a la posición de destino
            other.transform.position = teleportPosition;

            overlay.GetComponent<Animator>().SetTrigger("Play");

            StartCoroutine(ResetAnimationTrigger());
        }
    }

    private IEnumerator ResetAnimationTrigger()
    {
        // Espera un frame para asegurarse de que la animación ha comenzado
        yield return null;
        
        // Espera un momento (por ejemplo, 0.1 segundos) para permitir que la animación se reproduzca
        yield return new WaitForSeconds(0.1f);

        // Resetea el trigger de la animación
        overlay.GetComponent<Animator>().ResetTrigger("Play"); // Reemplaza "PlayAnimation" con el nombre del trigger de tu animación
    }
}
