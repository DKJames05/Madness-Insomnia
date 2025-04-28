using UnityEngine;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using System.Collections;

public class Winning : MonoBehaviour
{
    public GameObject Winner;
   
    public void PlayGame()
    {
        SceneManager.LoadScene("Actions");
    }

    public void Menu()
    {
        Debug.Log("Loading menu...");
        SceneManager.LoadScene("Title screen");
    }
    public void NextLevel()
    {
        Debug.Log("Loading the next level");
        SceneManager.LoadScene("SecondLevel");
    }
}
