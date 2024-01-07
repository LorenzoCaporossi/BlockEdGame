using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainmenu : MonoBehaviour
{
    
    public void OnNormalMode()
    {
        SceneManager.LoadScene("NormalMode");
    }



    public void OnChallengeMode()
    {
        SceneManager.LoadScene(2);
    }



    public void OnQuit()
    {
        Application.Quit();
    }

}

