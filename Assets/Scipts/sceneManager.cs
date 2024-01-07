using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class sceneManager : MonoBehaviour
{
    int currentSceneIndex = 1;

    void Start()
    {
        // Carica la prima scena
        SceneManager.LoadScene(currentSceneIndex, LoadSceneMode.Single);
    }

    public void OnClickNext()
    {
        currentSceneIndex++;

        if (currentSceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            // Carica la scena successiva in modo additivo
            SceneManager.LoadScene(currentSceneIndex, LoadSceneMode.Additive);
            if(currentSceneIndex  > 2)
            // Scarica la scena precedente
            SceneManager.UnloadSceneAsync(currentSceneIndex - 1);
        }
        else
        {
            Debug.Log("Non ci sono altre scene successive.");
        }
    }
}
