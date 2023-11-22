using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class habitacion2 : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    public bool isHabitacion2;
    public GameObject npcObj;
    private Collider npcCollider;
    void Start()
    {
        npcCollider = npcObj.GetComponent<Collider>();

        minX = -300f;
        maxX = -227;
        minZ = -305;
        maxZ = -371f;
    }
    void Update()
    {
        if (npcCollider.bounds.Intersects(GetComponent<Collider>().bounds))
        {
            isHabitacion2 = true;
        }
        else
        {
            isHabitacion2 = false;
        }
    }
}
