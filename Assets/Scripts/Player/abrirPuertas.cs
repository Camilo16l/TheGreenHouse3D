using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrirPuertas : MonoBehaviour
{
    public bool requiereLlaveAzul;
    public bool requiereLlaveVerde;
    public bool requiereLlaveFinal;
    private Animator anim;
    public inventario inventario;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(requiereLlaveAzul)
        {
            LlaveAzul();
        }
        if(requiereLlaveVerde)
        {
            LlaveVerde();
        }
        if(requiereLlaveFinal)
        {
            LlaveFinal();
        }
    }

    void LlaveAzul()
    {
        if(inventario.usedBlueKey)
        {
            anim.SetBool("open", true);
        }
    }
    void LlaveVerde()
    {
        if(inventario.usedGreenKey)
        {
            anim.SetBool("open", true);
        }
    }
    void LlaveFinal()
    {
        if(inventario.usedFinalKey)
        {
            anim.SetBool("open", true);
        }
    }
}
