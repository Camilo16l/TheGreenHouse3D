using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buscarObjeto : MonoBehaviour
{
    public investigar investigarScript;
    public inventario inventary;
    public bool mapa;
    public bool espada;
    public bool botiquin;
    public bool pistola;
    public bool cuchillo;
    public bool pastel;
    public bool llave;

    void Update()
    {
        if(investigarScript.investigado)
        {
            if (mapa)
            {
                inventary.mapa = true;
            }
            else if(espada)
            {
                inventary.espada = true;
            }
            else if(botiquin)
            {
                inventary.botiquin = true;
            }
            else if(pistola)
            {
                inventary.pistola = true;
            }
            else if(cuchillo)
            {
                inventary.cuchillo = true;
            }
            else if(pastel)
            {
                inventary.pastel = true;
            }
            else if(llave)
            {
                inventary.llaveFinal = true;
            }
        }
    }
}
