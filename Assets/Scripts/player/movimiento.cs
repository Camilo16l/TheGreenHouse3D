using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class movimiento : MonoBehaviour
{
    private Rigidbody rb;
    public int velocidad = 5;
    public bool isMoving = false;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        ManejarEntrada();
    }

    private void ManejarEntrada()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        Vector3 direccion = new Vector3(movimientoHorizontal, 0f, movimientoVertical).normalized;

        if (direccion.magnitude >= 0.1f)
        {
            isMoving = true;
            Quaternion lookRotation = Quaternion.LookRotation(direccion);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 10f);

            // Vector3 movimientoVelocidad = direccion * velocidad * Time.deltaTime;
            // rb.MovePosition(transform.position + movimientoVelocidad);
            rb.position += direccion * velocidad * Time.deltaTime;
        }
        else
        {
            isMoving = false;
        }
    }
}