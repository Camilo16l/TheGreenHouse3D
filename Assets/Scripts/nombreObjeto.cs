using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nombreObjeto : MonoBehaviour
{
    public float posicion = 1.5f;
    public string cubeName = "Nombre del Cubo"; // Cambia esto por el nombre que desees

    public int fontSize = 20;

    private bool isMouseOver = false;

    private void OnMouseEnter()
    {
        if (gameObject.layer == LayerMask.NameToLayer("Mouse"))
        {
            isMouseOver = true;
            Debug.Log("Mouse sobre el cubo: " + cubeName);
        }
    }

        private void OnMouseExit()
    {
        isMouseOver = false;
    }

    private void OnGUI()
    {
        if (isMouseOver)
        {
            GUIStyle style = new GUIStyle(GUI.skin.label);
            style.fontSize = fontSize;

            Vector3 screenPosition = Camera.main.WorldToScreenPoint(transform.position + Vector3.up * posicion);
            GUI.Label(new Rect(screenPosition.x - 50, Screen.height - screenPosition.y, 100, 20), cubeName);
        }
    }

    void Start()
    {
        
    }


    void Update()
    {

    }
}
