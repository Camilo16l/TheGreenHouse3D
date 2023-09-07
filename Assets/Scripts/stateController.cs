using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class stateController : MonoBehaviour
{
    public bool atacando = false;
    public Image mouse;
    public Sprite cursorVerde;
    public Sprite cursorRojo;

    void Start()
    {
        Cursor.visible = false;
        atacando = false;
        mouse.sprite = cursorVerde;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            atacando = !atacando;
            UpdateSprite();
        }
    }

    void UpdateSprite()
    {
        if (atacando)
        {
            mouse.sprite = cursorRojo;
        }
        else
        {
            mouse.sprite = cursorVerde;
        }
    }
}
