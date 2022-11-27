using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene(1); // Jeu H vs H = 1
    }

    public void GoToMM()
    {
        SceneManager.LoadScene(0); // Ecran de demarge = 0
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
        //Just to make sure its working
    }
}
