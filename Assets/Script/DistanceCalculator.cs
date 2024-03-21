using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceCalculator : MonoBehaviour
{

    // Start is called before the first frame update
    [SerializeReference] 
    public Transform objetoA;
    [SerializeReference] 
    public Transform puntoDeOrigen;
    [SerializeReference] 
    public Transform puntoC;

    void Start()
    {
        float distanciaAOBJ = Vector3.Distance(objetoA.position, transform.position);
        float distanciaAlOrigen = Vector3.Distance(puntoDeOrigen.position, transform.position);
        float distanciaAlPuntoC = Vector3.Distance(puntoC.position, transform.position);

        Debug.Log("Distancia de Objeto B a Objeto A: " + distanciaAOBJ);
        Debug.Log("Distancia de Objeto B al Punto de Origen: " + distanciaAlOrigen);
        Debug.Log("Distancia de Objeto B al Punto C: " + distanciaAlPuntoC);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
