using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personajeNPC : MonoBehaviour
{
    public GameObject player;
    public Transform NpcObj;
    public GameObject[] personajes;
    private GameObject personajeSeleccionado;
    
    public bool muerto;
    public scriptNPC scriptNPC;
    // public walk WalkScript;
    public bool movimiento = false;
    private Animator animator;

    void Start()
    {
        muerto = false;
        PersonajeAleatorio();

        animator = personajeSeleccionado.GetComponent<Animator>();
    }


    void Update()
    {
        if (personajeSeleccionado != null)
        {
            personajeSeleccionado.transform.position = new Vector3(NpcObj.position.x, 1f, NpcObj.position.z);

            // if (!WalkScript.Rotating)
            //     {
            //         personajeSeleccionado.transform.rotation = NpcObj.rotation;
            //     }
        }
        
        muerto = scriptNPC.muerto;

        animator.SetBool("muerto", muerto);

        // movimiento = WalkScript.walking;

        animator.SetBool("movimiento", movimiento);
    }

    void PersonajeAleatorio()
    {
        if (personajes.Length > 0)
        {
            int indiceAleatorio = Random.Range(0, personajes.Length);

            personajeSeleccionado = personajes[indiceAleatorio];

            Debug.Log("Personaje seleccionado: " + personajeSeleccionado.name);
        }
        else
        {
            Debug.LogError("No hay personajes en el array.");
        }
    }
}
