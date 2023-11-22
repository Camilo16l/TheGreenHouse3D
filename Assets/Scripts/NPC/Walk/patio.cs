using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patio : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    public bool isPatio;
    public GameObject npcObj;
    private Collider npcCollider;
    void Start()
    {
        npcCollider = npcObj.GetComponent<Collider>();

        minX = -115f;
        maxX = 55f;
        minZ = -575f;
        maxZ = -715f;
    }
    void Update()
    {
        if (npcCollider.bounds.Intersects(GetComponent<Collider>().bounds))
        {
            isPatio = true;
        }
        else
        {
            isPatio = false;
        }
    }
}
