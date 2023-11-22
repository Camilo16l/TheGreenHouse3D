using UnityEngine;

public class atico : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    public bool isAtico;
    public GameObject npcObj;
    private Collider npcCollider;
    void Start()
    {
        npcCollider = npcObj.GetComponent<Collider>();

        minX = -46;
        maxX = 88;
        minZ = -9;
        maxZ = 95;
    }

    void Update()
    {
        if (npcCollider.bounds.Intersects(GetComponent<Collider>().bounds))
        {
            isAtico = true;
        }
        else
        {
            isAtico = false;
        }
    }
}
