using System.Collections.Generic;
using UnityEngine;

public class destinoCamara : MonoBehaviour
{
    public enum destinos
    {
        DestinoA, // Pasillo
        DestinoB, // Atico
        DestinoC, // Sala
        DestinoD, // Cuarto 1
        // DestinoE, // Cuarto 2
        // DestinoF, // Patio
    }

    public Dictionary<destinos, Vector3> destination = new Dictionary<destinos, Vector3>();
    public Transform destinoAPosition;
    public Transform destinoBPosition;
    public Transform destinoCPosition;
    public Transform destinoDPosition;
    // public Transform destinoEPosition;
    // public Transform destinoFPosition;

    void Start()
    {
        destination[destinos.DestinoA] = destinoAPosition.position;
        destination[destinos.DestinoB] = destinoBPosition.position;
        destination[destinos.DestinoC] = destinoCPosition.position;
        destination[destinos.DestinoD] = destinoDPosition.position;
        // destination[destinos.DestinoE] = destinoEPosition.position;
        // destination[destinos.DestinoF] = destinoFPosition.position;
    }
}
