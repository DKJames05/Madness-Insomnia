using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Madness Insomnia");
    }

    public void Quitgame()
    {
        Debug.Log("Quitting game....");
        Application.Quit();
    }
}
