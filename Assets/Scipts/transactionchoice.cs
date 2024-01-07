using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transactionchoice : MonoBehaviour
{
    public void OnT1()
    {
        SceneManager.LoadScene("T1");
    }

    public void OnT2()
    {
        SceneManager.LoadScene("T2");
    }

    public void OnT3()
    {
        SceneManager.LoadScene("T3");
    }

    public void OnT4()
    {
        SceneManager.LoadScene("T4");
    }
}
