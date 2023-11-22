using UnityEngine;

public class pasillo : MonoBehaviour
{
    public float minX;
    public float maxX;
    public float minZ;
    public float maxZ;
    public bool isPasillo;
    public GameObject npcObj;
    private Collider npcCollider;
    void Start()
    {
        npcCollider = npcObj.GetComponent<Collider>();

        minX = 200;
        maxX = 460;
        minZ = 12;
        maxZ = 77;
    }

    // Update is called once per frame
    void Update()
    {
        if (npcCollider.bounds.Intersects(GetComponent<Collider>().bounds))
        {
            isPasillo = true;
        }
        else
        {
            isPasillo = false;
        }
    }
}
