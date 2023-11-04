using UnityEngine;

public class slideSala : MonoBehaviour
{
    public Camera camara;
    public Transform[] sectores;
    public sliderHorizontal horizontal;
    public sliderVertical vertical;
    public sala sala;
    public bool slideVertical;
    public bool slideHorizontal;

    void Start()
    {
        slideVertical = vertical.slide;
        slideHorizontal = horizontal.slide;
    }
    void Update()
    {
        slideVertical = vertical.slide;
        slideHorizontal = horizontal.slide;

        if (sala.salaBool == true)
        {
            Slide();
        }
    }

    void Slide()
    {
        if (!slideVertical && !slideHorizontal)
        {
            camara.transform.position = sectores[0].position; // sector1
        }
        else if (!slideVertical && slideHorizontal)
        {
            camara.transform.position = sectores[1].position; // sector2
        }
        else if (slideVertical && !slideHorizontal)
        {
            camara.transform.position = sectores[2].position; // sector3
        }
        else if (slideVertical && slideHorizontal)
        {
            camara.transform.position = sectores[3].position; // sector4
        }
    }
}