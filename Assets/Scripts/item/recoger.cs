using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recoger : MonoBehaviour
{
    public inventario inventario;
    public bool itemCollected;
    void Start()
    {
        itemCollected = false;
    }

    void Update()
    {
        if (itemCollected)
        {
            gameObject.SetActive(false);
            if (gameObject.CompareTag("mapa"))
            {
                Debug.Log("Has recogido un pastel");
                inventario.mapa = true;
            }
            if (gameObject.CompareTag("pastel"))
            {
                Debug.Log("Has recogido un pastel");
                inventario.pastel = true;
            }
            if (gameObject.CompareTag("botiquin"))
            {
                Debug.Log("Has recogido un pastel");
                inventario.botiquin = true;
            }
            if (gameObject.CompareTag("cuchillo"))
            {
                Debug.Log("Has recogido un pastel");
                inventario.cuchillo = true;
            }
            if (gameObject.CompareTag("espada"))
            {
                Debug.Log("Has recogido un pastel");
                inventario.espada = true;
            }
            if (gameObject.CompareTag("pistola"))
            {
                Debug.Log("Has recogido un pastel");
                inventario.pistola = true;
            }
            if (gameObject.CompareTag("llaveAzul"))
            {
                Debug.Log("Has recogido un pastel");
                inventario.llaveAzul = true;
            }
            if (gameObject.CompareTag("llaveVerde"))
            {
                Debug.Log("Has recogido un pastel");
                inventario.llaveVerde = true;
            }
            if (gameObject.CompareTag("llaveFinal"))
            {
                Debug.Log("Has recogido un pastel");
                inventario.pastel = true;
            }      
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            itemCollected = true;
        }
    }
}
