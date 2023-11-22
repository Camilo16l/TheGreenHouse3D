using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class habitacion1 : MonoBehaviour
{
public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    public bool isHabitacion1;
    public GameObject npcObj;
    private Collider npcCollider;
    void Start()
    {
        npcCollider = npcObj.GetComponent<Collider>();

        minX = -375;
        maxX = -300;
        minZ = -64;
        maxZ = 4;
    }
    void Update()
    {
        if (npcCollider.bounds.Intersects(GetComponent<Collider>().bounds))
        {
            isHabitacion1 = true;
        }
        else
        {
            isHabitacion1 = false;
        }
    }
}
