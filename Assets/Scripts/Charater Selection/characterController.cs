using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class characterController : MonoBehaviour
{
    public List<characterSelection> characters = new List<characterSelection>(); // Lista de scripts characterSelection
    public int personajeSeleccionado;
    public Button boton;

    void Start()
    {
        personajeSeleccionado = 0;

        foreach (var character in characters)
        {
            character.OnCharacterSelected += UpdateSelectedCharacter;
        }

        boton.interactable = false;
        boton.gameObject.SetActive(false);
    }

    void UpdateSelectedCharacter(int selectedCharacter)
    {
        personajeSeleccionado = selectedCharacter;

        if (personajeSeleccionado != 0)
        {
            boton.interactable = true;
            boton.gameObject.SetActive(true);
        }
        else
        {
            boton.interactable = false;
            boton.gameObject.SetActive(false);
        }
    }

    void Update()
    {

    }
}