using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salah : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    public bool isSala;
    public GameObject npcObj;
    private Collider npcCollider;
    void Start()
    {
        npcCollider = npcObj.GetComponent<Collider>();

        minX = 228;
        maxX = 470;
        minZ = -510;
        maxZ = -230;
    }
    void Update()
    {
        if (npcCollider.bounds.Intersects(GetComponent<Collider>().bounds))
        {
            isSala = true;
        }
        else
        {
            isSala = false;
        }
    }
}
