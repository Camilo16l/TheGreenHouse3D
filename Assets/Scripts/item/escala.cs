using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escala : MonoBehaviour
{
    private Vector3 escalaNormal;
    public Vector3 escalaAgrandada;
    void Start()
    {
        escalaNormal = transform.localScale;
    }

    void OnMouseOver()
    {
        transform.localScale = escalaAgrandada;
    }

    void OnMouseExit()
    {
        transform.localScale = escalaNormal;
    }
}
