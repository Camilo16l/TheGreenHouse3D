using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scriptNPC : MonoBehaviour
{  
    private Collider myCollider;
    public stateController atacando;
    public bool muerto = false;
    public screenShake screenShake;
    public float distanciaAtaque = 3f;
    public GameObject player;
    public walk WalkScript;
    public Transform[] spawnpoints;
    public float velocidadMovimiento;
    public LayerMask ignoreLayer;
    public bool win;
    public string nombreDeLaEscena;
    public float salud;
    public float cooldown = .8f;
    private float lastAttack;
    private AudioSource audioSource;
    void Start()
    {
        myCollider = GetComponent<Collider>();
        audioSource = GetComponent<AudioSource>();
        muerto = false;
        win = false;
        int randomIndex = Random.Range(0, spawnpoints.Length);
        transform.position = new Vector3(spawnpoints[randomIndex].position.x, 7.5f, spawnpoints[randomIndex].position.z);
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            VerificarAtaque();
        }

        if(win)
        {
            CambiaEscena();
        }
    }
    public void VerificarAtaque()
    {
        if (Time.time - lastAttack < cooldown)
        {
            return;
        }

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        
        if (Physics.Raycast(ray, out hit, Mathf.Infinity, ~ignoreLayer))
        {
            if (hit.collider.gameObject == gameObject)
            {
                if(atacando.atacando && Vector3.Distance(transform.position, player.transform.position) <= distanciaAtaque)
                {
                    lastAttack = Time.time;
                    StartCoroutine(screenShake.Shake(0.1f, 2.5f));
                    Herir(1);
                }
            }
        }
    }

    public void Herir(int puntos)
    {
        salud -= puntos;
        if(salud<=0){
            Muerte();
        }
    }

    public void Muerte()
    {
        muerto = true;
        audioSource.Play();

        myCollider.enabled = false;

        WalkScript.enabled = false;
    }

    IEnumerator ActivarWin(float espera)
    {
        yield return new WaitForSeconds(espera);
        win = true;
    }

    public void CambiaEscena()
    {
        SceneManager.LoadScene(nombreDeLaEscena);
    }
}
