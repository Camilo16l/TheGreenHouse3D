using System.Collections.Generic;
using UnityEngine;

public class destinoCamara : MonoBehaviour
{
    public enum destinos
    {
        DestinoA,
        DestinoB,
        DestinoC,
        DestinoD,
        DestinoE,
        DestinoF,
        DestinoG,
        DestinoH,
        DestinoI,
    }

    public Dictionary<destinos, Vector3> destination = new Dictionary<destinos, Vector3>();
    public Transform destinoAPosition;
    public Transform destinoBPosition;
    public Transform destinoCPosition;
    public Transform destinoDPosition;
    public Transform destinoEPosition;
    public Transform destinoFPosition;
    public Transform destinoGPosition;
    public Transform destinoHPosition;
    public Transform destinoIPosition;

    void Start()
    {
        destination[destinos.DestinoA] = destinoAPosition.position;
        destination[destinos.DestinoB] = destinoBPosition.position;
        destination[destinos.DestinoC] = destinoCPosition.position;
        destination[destinos.DestinoD] = destinoDPosition.position;
        destination[destinos.DestinoE] = destinoEPosition.position;
        destination[destinos.DestinoF] = destinoFPosition.position;
        destination[destinos.DestinoG] = destinoGPosition.position;
        destination[destinos.DestinoH] = destinoHPosition.position;
        destination[destinos.DestinoI] = destinoIPosition.position;
    }
}
