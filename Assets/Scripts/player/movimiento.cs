using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class movimiento : MonoBehaviour
{
    private Rigidbody rb;
    public int velocidad = 30;
    public bool isMoving = false;
    public float distanciaMaxima = 1f;
    public float distanciaAtaque = 3f;
    public Transform npc;
    public scriptNPC scriptNPC;
    public float salud = 15f;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Movimiento();
    }

    private void Movimiento()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 direccion = new Vector3(movimientoHorizontal, 0f, movimientoVertical).normalized;

        if (direccion.magnitude >= 0.1f)
        {
            isMoving = true;
            Quaternion lookRotation = Quaternion.LookRotation(direccion);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 10f);

            RaycastHit hit;
            if (Physics.Raycast(transform.position, transform.forward, out hit, distanciaMaxima))
            {
                if (hit.collider != null && !hit.collider.isTrigger)
                {
                    isMoving = false;
                    return;
                }
            }

            rb.position += direccion * velocidad * Time.deltaTime;
        }
        else
        {
            isMoving = false;
        }
    }
    void Ataque()
    {

    }
}