using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class walk : MonoBehaviour
{
//Random Walking NPC 3D By René Pol 26-11-2022//
    public bool walking;
    public float WalkingTime;
    public float Speed;
    public bool Rotating;
    public int RotateDir;
    public float MaxX, MinX, MaxZ, MinZ;
    void Start()
    {
        WalkingTime = Random.Range(5, 8);
        Rotating = false;
        RotateDir = Random.Range(1, 3);
        walking = !Rotating;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("obstacle"))
        {
            transform.Rotate(0, -180, 0);
        }
    }
    void Update()
    {
        if (transform.position.x > MaxX | transform.position.x < MinX | transform.position.z > MaxZ | transform.position.z
        < MinZ)
        {
            transform.Rotate(0, -180, 0);
        }
            if (Rotating == true && RotateDir == 1)
        {
            WalkingTime -= Time.deltaTime;
            transform.Rotate(0, 15 * Speed * Time.deltaTime, 0);
            if (WalkingTime <= 0)
            {
                Rotating = false;
                WalkingTime = Random.Range(5, 10);
                walking = !Rotating;
            }
        }
        if (Rotating == true && RotateDir == 2)
        {
            WalkingTime -= Time.deltaTime;
            transform.Rotate(0, -15 * Speed * Time.deltaTime, 0);
            if (WalkingTime <= 0)
            {
                Rotating = false;
                WalkingTime = Random.Range(5, 8);
                walking = !Rotating;
            }
        }
        if (Rotating == false)
        {
            // Anim.Play("Walk");
            WalkingTime -= Time.deltaTime;
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
            if (WalkingTime <= 0)
            {
                RotateDir = Random.Range(1, 3);
                Rotating = true;
                WalkingTime = Random.Range(5, 8);
                walking = !Rotating;
            }
        }
    }
}