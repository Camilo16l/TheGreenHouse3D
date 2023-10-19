using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class characterSelection : MonoBehaviour
{
    public int character = 1;
    public UnityAction<int> OnCharacterSelected;

    public void SelectCharacter(int selectedCharacter)
    {
        character = selectedCharacter;
        Debug.Log("Personaje seleccionado: " + character);

        OnCharacterSelected?.Invoke(character);
    }
}