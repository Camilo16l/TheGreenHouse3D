using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncing : MonoBehaviour
{
    public float speed = 2.0f;
    public float distance = 1.0f;

    private Vector3 initialPosition;
    void Start()
    {
        initialPosition = transform.position;
    }
    void Update()
    {
        float yOffset = Mathf.Sin(Time.time * speed) * distance;
        transform.position = new Vector3(initialPosition.x, initialPosition.y + yOffset, initialPosition.z);
    }
}
