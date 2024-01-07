using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineConnect : MonoBehaviour
{
    public Transform header1; // Riferimento al primo oggetto
    public Transform data2; // Riferimento al secondo oggetto
    private LineRenderer lineRenderer;

    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    void Update()
    {
        // Imposta le posizioni dei punti di inizio e fine della linea
        lineRenderer.SetPosition(0, header1.position);
        lineRenderer.SetPosition(1, data2.position);
    }
}
