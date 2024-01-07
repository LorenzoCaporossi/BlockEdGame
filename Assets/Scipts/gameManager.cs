using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    
    // Esempio di variabile per mantenere un punteggio
    public int score;

    // Puoi aggiungere altre variabili o logica per mantenere i dati

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
