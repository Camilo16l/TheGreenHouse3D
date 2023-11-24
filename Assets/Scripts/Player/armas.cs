using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class armas : MonoBehaviour
{

    public scriptNPC saludEnemy;
    public inventario inventario;

    void Update()
    {
        if (inventario.cuchillo)
        {
            Cuchillo();
        }
        else if (inventario.espada)
        {
            Espada();
        }
        else if (inventario.pistola)
        {
            Pistola();
        }
        else
        {
            DañoDefault();
        }
    }

    void Cuchillo()
    {
        Debug.Log("Usando Cuchillo");
        saludEnemy.Herir(3);
    }
    void Espada()
    {
        Debug.Log("Usando Espada");
        saludEnemy.Herir(5);
    }
    void Pistola()
    {
        Debug.Log("Usando Pistola");
        saludEnemy.Herir(8);
    }
    void DañoDefault()
    {
        saludEnemy.Herir(1);
    }
}
