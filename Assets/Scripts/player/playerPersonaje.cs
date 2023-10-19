using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerPersonaje : MonoBehaviour
{
    public GameObject personaje;
    public GameObject player;
    public float offset = 0.5f;
    private Animator animator;
    public bool movimiento = false;
    public movimiento moving;
    
    void Start()
    {
        animator = personaje.GetComponent<Animator>();
    }

    void Update()
    {
        Vector3 newPosition = new Vector3(player.transform.position.x, offset, player.transform.position.z);
        personaje.transform.position = newPosition;

        personaje.transform.rotation = Quaternion.Euler(0f, player.transform.rotation.eulerAngles.y, 0f);

        movimiento = moving.isMoving;

        animator.SetBool("movimiento", movimiento);
    }
}
