using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sala : MonoBehaviour
{
    public bool salaBool = false;
    void Start()
    {
        salaBool = false;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            salaBool = !salaBool;
        }
    }
    void Update()
    {
        
    }
}
