using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeMovement : MonoBehaviour
{

    public float moveSpeed = 1.0f;
    public float rotationSpeed = 30.0f;
    public float maxY = 2.0f;
    public float minY = 0.0f;
    private float startingY;

    void Start()
    {
        startingY = transform.position.y;
    }


    void Update()
    {
        float newY = Mathf.PingPong(Time.time * moveSpeed, maxY - minY) + minY;
        Vector3 newPosition = new Vector3(transform.position.x, newY, transform.position.z);
        transform.position = newPosition;

        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
