using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posicionPlayer : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        Vector3 newPosition = transform.position;

        newPosition.x = player.position.x;
        newPosition.z = player.position.z;

        transform.position = newPosition;
    }
}
