using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class next : MonoBehaviour
{
    public void OnClicNext()
    {
        int nextScene = SceneManager.GetActiveScene().buildIndex + 1;

        if (nextScene < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextScene);
        }
        else
        {
            Debug.Log("Non ci sono altre scene successive.");
            // Oppure puoi tornare alla prima scena:
            // SceneManager.LoadScene(0);
        }
    }
}
