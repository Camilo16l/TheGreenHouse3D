using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public Transform player;
    public GameObject npc;
    public scriptNPC Script;
    public walk walkScript;
    public bool isEnemy;
    public GameObject[] rooms;
    public float rotationSpeed = 180.0f;
    public float attackRange = 2.0f;
    public float timeBetweenAttacks = 1.0f;
    private float attackTimer = 0.0f;
    public movimiento pHealth;
    public screenShake screenShake;
    void Update()
    {
        
        GetRoomComponents();

        if (isEnemy && !Script.muerto)
        {
            Enemy();
            walkScript.enabled = false;
        }
        else
        {
            walkScript.enabled = true;
        }
        if (Script.muerto)
        {
            Debug.Log("muertooo");
        }
    }
    void Enemy()
    {
        Vector3 directionToPlayer = player.position - npc.transform.position;
        directionToPlayer.Normalize();
        npc.transform.position = Vector3.MoveTowards(npc.transform.position, player.position, walkScript.Speed * Time.deltaTime);
        Quaternion toRotation = Quaternion.LookRotation(directionToPlayer, Vector3.up);
        npc.transform.rotation = Quaternion.RotateTowards(npc.transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
        float distanceToPlayer = Vector3.Distance(npc.transform.position, player.position);

        if (distanceToPlayer <= attackRange)
        {
            Attack();
        }
    }
    void Attack()
    {
        if (attackTimer <= 0.0f)
        {
            Herir();
            attackTimer = timeBetweenAttacks;
        }
        else
        {
            attackTimer -= Time.deltaTime;
        }
    }

    void Herir()
    {
        StartCoroutine(screenShake.Shake(0.1f, 2.5f));
        pHealth.salud--;
        Vector3 directionToPlayer = (npc.transform.position - player.position).normalized;
        Vector3 knockbackDirection = directionToPlayer;
        StartCoroutine(Knockback(knockbackDirection, 11f));        
    }
    IEnumerator Knockback(Vector3 direction, float duration)
    {
        float timer = 0.0f;
        Transform enemyTransform = npc.transform;

        while (timer < duration)
        {
            enemyTransform.position += direction * Time.deltaTime;
            Vector3 newDirection = (player.position - enemyTransform.position).normalized;
            Quaternion toRotation = Quaternion.LookRotation(newDirection, Vector3.up);
            enemyTransform.rotation = Quaternion.RotateTowards(enemyTransform.rotation, toRotation, rotationSpeed * Time.deltaTime);

            timer += Time.deltaTime;
            yield return null;
        }
    }

    void GetRoomComponents()
    {
        isEnemy = false;

        foreach (GameObject room in rooms)
        {
            detectorHabitacion detector = room.GetComponent<detectorHabitacion>();
            if (detector != null && detector.detectado)
            {
                isEnemy = true;
                break;
            }
        }
    }
}
