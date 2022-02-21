using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void MainGame()
    {
        SceneManager.LoadScene("Stage1");
        Time.timeScale = 1f;
    }

    public void LevelGame()
    {
        SceneManager.LoadScene("Level");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is Exiting");
    }

    public void MenuMain()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void NextStage()
    {
        SceneManager.LoadScene("Stage2");
    }
}