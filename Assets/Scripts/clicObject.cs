using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class clicObject : MonoBehaviour
{
    public GameObject mouse;
    // public GameObject target;
    public GameObject item;
    public Vector2 offset = new Vector2(-550, -245);
    private RectTransform rectTransform;
    private Canvas canvas;
    public bool isDragging = false;
    void Start()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponentInParent<Canvas>();
    }


    void Update()
    {
        if (isDragging)
        {
            Vector2 screenPosition = Input.mousePosition;

            RectTransformUtility.ScreenPointToLocalPointInRectangle(canvas.transform as RectTransform, screenPosition, canvas.worldCamera, out Vector2 canvasPosition);

            rectTransform.anchoredPosition = canvasPosition + offset;
        }
    
    }
        private void OnMouseDown()
        {
            if (item == EventSystem.current.currentSelectedGameObject)
            {
                isDragging = true;
            }
        }
        private void OnMouseUp()
        {
            isDragging = false;
        }
    

}
