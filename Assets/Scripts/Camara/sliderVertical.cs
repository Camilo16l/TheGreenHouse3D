using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sliderVertical : MonoBehaviour
{
    public bool slide = false;
    void Start()
    {
        slide = false;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            slide = !slide; // Invierte el valor de slide al pasar por el trigger.
        }
    }
}
