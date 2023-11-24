using UnityEngine;
using UnityEngine.UI;
public class playerHealth : MonoBehaviour
{
    public GameObject barra;
    public Transform playerPosition;
    public Image bar;
    public Image border;
    public movimiento salud;
    public float vidaActual;
    public float porcentaje = 1;
    private float vidaMaxima;
    void Start()
    {
        vidaActual = salud.salud;
    }
    void HealthUpdate()
    {  
        vidaMaxima = salud.salud;
        porcentaje = Mathf.Clamp(vidaMaxima / vidaActual, 0f, 1f);
        bar.fillAmount = porcentaje;
    }
    void Seguir()
    {
        Vector3 playerScreenPosition = Camera.main.WorldToScreenPoint(playerPosition.position);
        barra.transform.position = playerScreenPosition + new Vector3(0, 140, 0);
    }
    void Update()
    {
        Seguir();
        HealthUpdate();
    }
}
