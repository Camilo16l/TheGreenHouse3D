using UnityEngine;

public class slideCamera : MonoBehaviour
{
    public bool slide = false;
    public Camera camara;
    public Transform derecha;
    public Transform izquierda;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            slide = !slide; // Invierte el valor de slide al pasar por el trigger.

            if (slide)
            {
                Derecha(); // Llama al método Izquierda si slide es true.
            }
            else
            {
                Izquierda(); // Llama al método Derecha si slide es false.
            }
        }
    }

    void Derecha()
    {
        camara.transform.position = derecha.transform.position;
        Debug.Log("Deslizamiento hacia la derecha");
    }

    void Izquierda()
    {
        camara.transform.position = izquierda.transform.position;
        Debug.Log("Deslizamiento hacia la izquierda");
    }
}
