// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class llave : MonoBehaviour
// {
//     public sprites spriteScript;
//     public Transform door;
//     public float velocidad = 5;
//     void Start()
//     {
//         if (door == null)
//         {
//             Debug.LogError("doorTransform is not asigned");
//         }
//     }

//     void Update()
//     {
//         if (spriteScript != null && spriteScript.activated)
//         {
//             door.Translate(Vector3.down * Time.deltaTime * velocidad);
//         }
//     }
// }
