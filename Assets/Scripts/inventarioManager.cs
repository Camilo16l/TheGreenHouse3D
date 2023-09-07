using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inventarioManager : MonoBehaviour
{
    public int clickCounter = 0;
    public bool canClick = true;
    

    private void Update()
    {
        if (!canClick)
            return;

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.CompareTag("objeto"))
                {
                    clickCounter++;

                    if (clickCounter >= 6)
                    {
                        canClick = false;
                        Debug.Log("Contador alcanzó 5. No se puede contar más.");
                    }
                    else
                    {
                        Debug.Log("Contador: " + clickCounter);
                    }
                }
            }
        }
    }

}
