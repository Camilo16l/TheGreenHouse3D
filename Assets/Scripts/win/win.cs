using UnityEngine;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    public bool readyToWin;
    public inventario inventario;
    public string nombreDeLaEscena;
    // public float tiempoEspera = 0.1f;

    void Start()
    {
        readyToWin = false;
    }
    void Update()
    {
        if(inventario.llaveAzul && inventario.llaveVerde && inventario.llaveFinal)
        {
            readyToWin = true;
        }
        else
        {
            readyToWin = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(readyToWin)
            {  
                CambiaEscena();
            }
        }
    }

    public void CambiaEscena()
    {
        SceneManager.LoadScene(nombreDeLaEscena);
    }
}
