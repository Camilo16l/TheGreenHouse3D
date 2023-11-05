using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sala : MonoBehaviour
{
    public static bool salaBool = false;
    public bool verificar = false;
    void Start()
    {
        salaBool = false;
        verificar = false;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            salaBool = true;
        }
    }

        void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            salaBool = false;
        }
    }
    void Update()
    {
        verificar = salaBool;
    }
}
