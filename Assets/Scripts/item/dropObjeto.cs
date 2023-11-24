using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropObjeto : MonoBehaviour
{
    public investigar investigarScript;
    public GameObject item;
    public bool hasDropped;

    public float spawnOffset = 1.0f;
    void Update()
    {
        if (investigarScript.investigado && !hasDropped)
        {
            DropItem();
            hasDropped = true;
        }        
    }

    private void DropItem()
    {
        Vector3 spawnPosition = new Vector3(transform.position.x + spawnOffset, transform.position.y - spawnOffset, transform.position.z - 15);

        Instantiate(item, spawnPosition, Quaternion.identity);
    }
}
