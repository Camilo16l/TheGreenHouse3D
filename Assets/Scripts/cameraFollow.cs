using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
public Transform player;
public Vector3 offset = new Vector3(0f, 10f, -10f);

private void LateUpdate()
    {
        if (player != null)
        {
            Vector3 desiredPosition = player.position + offset;


            transform.position = desiredPosition;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
