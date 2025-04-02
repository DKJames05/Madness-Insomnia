using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Actions");
    }

    public void Quitgame()
    {
        Debug.Log("Quitting game....");
        Application.Quit();
    }
}
