using UnityEngine;
using UnityEngine.UI;

public class enemyHealth : MonoBehaviour
{
    public scriptNPC enemy;
    public GameObject barra;
    public Transform enemyPosition;
    public Image bar;
    public Image border;
    public float vida;
    public float porcentaje = 1;
    private float health;

    void Start()
    {
        vida = enemy.salud;
        SetBarVisible(false);
    }

    void HealthUpdate()
    { 
        health = enemy.salud;
        porcentaje = health / vida;
        porcentaje = Mathf.Clamp01(porcentaje);
        bar.fillAmount = porcentaje;

        SetBarVisible(health < vida);
    }

    void SetBarVisible(bool isVisible)
    {
        bar.enabled = isVisible;
        border.enabled = isVisible;
    }
    void Seguir()
    {
        Vector3 enemyScreenPosition = Camera.main.WorldToScreenPoint(enemy.transform.position);
        transform.position = enemyScreenPosition + new Vector3(0, 140, 0);
    }

    void Update()
    {
        HealthUpdate();
        Seguir();
        if (health == 0)
        {
            border.enabled = false;
        }
    }
}
