using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggers : MonoBehaviour
{
    public bool adentro;
    public GameObject camara;
    public GameObject player;
    public Transform posicion;
    public Transform posicionSala;
    private Coroutine currentCoroutine;
    
    void Update()
    {

    }
    void OnTriggerExit(Collider other)

    {
        if (currentCoroutine != null)
            {
                StopCoroutine(currentCoroutine);
            }
            
        if (other.gameObject == player)
        {
            adentro = !adentro;
            if (adentro)
            {
                StartCoroutine(Adentro());
            }
            else
            {
                StartCoroutine(Afuera());
            }
            
        }
    }
    private IEnumerator Adentro()
    {
        while (adentro)
        {
            camara.transform.position = posicion.position;
            yield return null;
        }
        
    }
    private IEnumerator Afuera()
    {
        while (!adentro)
        {
            camara.transform.position = posicionSala.position;
            yield return null;
        }
    }
}
