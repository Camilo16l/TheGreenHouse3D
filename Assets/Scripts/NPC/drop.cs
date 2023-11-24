using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drop : MonoBehaviour
{
    public scriptNPC scriptNPC;
    public GameObject item;
    public bool hasDropped;

    // Update is called once per frame
    void Update()
    {
        if (scriptNPC.muerto && !hasDropped)
        {
            DropItem();
            hasDropped = true;
        }
    }
    private void DropItem()
    {
        Instantiate(item, transform.position, Quaternion.identity);
    }
}
