using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class scriptNPC : MonoBehaviour
{  
    private Collider myCollider;
    public bool asesino;
    public stateController atacando;
    public bool muerto = false;
    public screenShake screenShake;
    public float distanciaAtaque = 3f;
    public GameObject player;
    public walk WalkScript;
    public Transform[] waypoints;
    public float velocidadMovimiento;
    public LayerMask ignoreLayer;
    void Start()
    {
        myCollider = GetComponent<Collider>();

        muerto = false;
        // asesino = (Random.value > 0.5f);
        asesino = true;

        int randomIndex = Random.Range(0, waypoints.Length);
        transform.position = new Vector3(waypoints[randomIndex].position.x, 7.5f, waypoints[randomIndex].position.z);
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            VerificarAtaque();
        }
    }

    void Normal()
    {

    }
    void Asesino()
    {

    }
    public void VerificarAtaque()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, ~ignoreLayer))
        {
            if (hit.collider.gameObject == gameObject)
            {
                if(atacando.atacando && Vector3.Distance(transform.position, player.transform.position) <= distanciaAtaque)
                {
                    Muerte();
                }
            }
        }
    }
    public void Muerte()
    {
        muerto = true;

        myCollider.enabled = false;

        StartCoroutine(screenShake.Shake(0.1f, 2.5f));

        WalkScript.enabled = false;
    }
}
