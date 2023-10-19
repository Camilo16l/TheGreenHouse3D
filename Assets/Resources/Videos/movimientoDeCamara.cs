using UnityEngine;

public class movimientoDeCamara : MonoBehaviour
{
    public Transform nuevaPosicion; // La nueva posición a la que se moverá la cámara

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Reemplaza "Player" con el tag del objeto que activará el trigger
        {
            // Mover la cámara a la nueva posición
            Rigidbody rb = GetComponent<Rigidbody>();
            rb.MovePosition(nuevaPosicion.position);
        }
    }
}