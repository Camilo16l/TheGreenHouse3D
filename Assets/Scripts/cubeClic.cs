using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeClic : MonoBehaviour
{
    public Transform player;
    public float activationDistance = 2.0f;
    public Color rayColor = Color.red;
    public inventarioManager inventario;
    public Sprite sprite;
    public Vector3 spriteSpawnPosition;
    private SpriteRenderer spriteRenderer;
    private GameObject spawnedSprite;
    // public bool recogido = false;
    public event System.Action<bool> OnRecogidoChanged;
    private bool _recogido = false;
    public bool recogido

    {
        get { return _recogido; }
        set
        {
            _recogido = value;
            OnRecogidoChanged?.Invoke(value);
        }
    }

    private void Star()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

        void Update()
        {
            float distance = Vector3.Distance(transform.position, player.position);

                if (distance <= activationDistance && Input.GetMouseButtonDown(0) && inventario.canClick)
                {
                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;

                    if (Physics.Raycast(ray, out hit) && hit.collider.gameObject == gameObject)
                        {
                            recogido = true;
                            gameObject.SetActive(false);
                        }
                }
        }

        private void OnDrawGizmos()
    {
        
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Gizmos.color = rayColor;
        Gizmos.DrawRay(ray.origin, ray.direction * activationDistance);
    }
}
