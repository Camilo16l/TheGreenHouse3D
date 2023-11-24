using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimientoObjeto : MonoBehaviour
{
    private Animator anim;
    public investigar investigarScript;

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    
    void Update()
    {
        if(investigarScript.investigado)
        {
            ActivarAnimacion();
        }
    }
    
    void ActivarAnimacion()
    {
        anim.SetBool("mover", true);
    }
}
