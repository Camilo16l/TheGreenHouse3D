using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class boton : MonoBehaviour
{
    // Nombre de la escena a la que quieres cambiar
    public string nombreDeLaEscena;

    // Este método se llama cuando se hace clic en el botón
    public void CambiarAEscena()
    {
        // Cambia a la escena con el nombre especificado
        SceneManager.LoadScene(nombreDeLaEscena);
    }
}
