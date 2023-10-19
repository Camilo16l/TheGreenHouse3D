// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;

// public class sprites : MonoBehaviour
// {
//     public Image imageToChange;
//     public Sprite spriteToShow;
//     public cubeClic cubeClickScript;
//     public bool activated = false;
//     void Start()
//     {
//         if (cubeClickScript == null)
//         {
//             Debug.LogError("cubeClickScript is not assigned!");
//             return;
//         }

//         cubeClickScript.OnRecogidoChanged += UpdateImageSprite;
//     }

//     private void OnDestroy()
//     {
//         if (cubeClickScript != null)
//         {
//             cubeClickScript.OnRecogidoChanged -= UpdateImageSprite;
//         }
//     }

//     private void UpdateImageSprite(bool newRecogidoValue)
//     {
//         if (newRecogidoValue && spriteToShow != null)
//         {
//             imageToChange.sprite = spriteToShow;
//             activated = true;
//         }
//     }


//     void Update()
//     {
        
//     }
// }
