using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectorHabitacion : MonoBehaviour
{
    public bool detectado;

    void Start()
    {
        detectado = false;
    }
private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("enemy"))
        {
            detectado = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("enemy"))
        {
            detectado = false;
        }
    }
}
