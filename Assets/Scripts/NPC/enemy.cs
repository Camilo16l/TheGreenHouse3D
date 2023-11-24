using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    // public Transform player;
    // public GameObject npc;
    // public scriptNPC Script;
    // public walk walkScript;
    // public bool isEnemy;
    // private bool isMoving = true;
    // private bool isAttacking = false;
    // public GameObject[] rooms;
    // public float rotationSpeed = 180.0f;
    // public float attackRange = 200f;
    // private float distanceToPlayer;
    // public float timeBetweenAttacks = 1.0f;
    // private float attackTimer = 0.0f;
    // public movimiento pHealth;
    // public screenShake screenShake;
    // public knocback knocback;
    // public float knockbackForce = 50.0f;

    
    // void Update()
    // {
        
    //     GetRoomComponents();

    //     if (isEnemy && !Script.muerto)
    //     {
    //         Enemy();
    //         if (isMoving)
    //         {
    //             walkScript.enabled = false;
    //         }
    //         else
    //         {
    //             walkScript.enabled = true;
    //         }
    //     }
    //     else
    //     {
    //         walkScript.enabled = true;
    //     }
    //     if (Script.muerto)
    //     {
    //         Debug.Log("muertooo");
    //     }
    // }
    // void Enemy()
    // {
    //     Seguir();
    //     if (distanceToPlayer <= attackRange)
    //     {
    //         isAttacking = true;
    //         Attack();
    //     }
    //     else
    //     {
    //         isAttacking = false;
    //     }
    // }
    //     private void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.collider.CompareTag("Player") || collision.collider.CompareTag("obstacle"))
    //     {
    //         // Aquí puedes agregar lógica adicional si es necesario
    //         isMoving = false; // Detener el movimiento cuando colisiona con el jugador u otro objeto
    //     }
    // }
    // private void OnCollisionExit(Collision collision)
    // {
    //     if (collision.collider.CompareTag("Player") || collision.collider.CompareTag("obstacle"))
    //     {
    //         // Aquí puedes agregar lógica adicional si es necesario
    //         isMoving = true; // Reactivar el movimiento cuando deja de colisionar con el jugador u otro objeto
    //     }
    // }
    // void Seguir()
    // {
    //     Vector3 directionToPlayer = player.position - npc.transform.position;
    //     directionToPlayer.Normalize();
    //     npc.transform.position = Vector3.MoveTowards(npc.transform.position, player.position, walkScript.Speed * Time.deltaTime);
    //     Quaternion toRotation = Quaternion.LookRotation(directionToPlayer, Vector3.up);
    //     npc.transform.rotation = Quaternion.RotateTowards(npc.transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
    //     distanceToPlayer = Vector3.Distance(npc.transform.position, player.position); // Asignar valor a la variable
    // }

    // void Attack()
    // {
    //     if (attackTimer <= 0.0f)
    //     {
    //         Herir();
    //         attackTimer = timeBetweenAttacks;
    //     }
    //     else
    //     {
    //         attackTimer -= Time.deltaTime;
    //     }
    // }

    // void Herir()
    // {
    //     isAttacking = false;
    //     StartCoroutine(screenShake.Shake(0.1f, 2.5f));
    //     pHealth.salud--;

    //     knocback.ApplyKnockback(player, knockbackForce);

    //     movimiento playerMovement = player.GetComponent<movimiento>();
    //     if (playerMovement != null)
    //     {
    //         playerMovement.ApplyKnockback(knockbackForce);
    //     }
    // }

    // void GetRoomComponents()
    // {
    //     isEnemy = false;

    //     foreach (GameObject room in rooms)
    //     {
    //         detectorHabitacion detector = room.GetComponent<detectorHabitacion>();
    //         if (detector != null && detector.detectado)
    //         {
    //             isEnemy = true;
    //             break;
    //         }
    //     }
    // }
}
