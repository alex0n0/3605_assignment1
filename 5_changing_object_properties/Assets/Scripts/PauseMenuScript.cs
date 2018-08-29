using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public string mainMenuSceen;
    public string resetScene;
    public static bool isPaused = false;
    public GameObject pauseUI;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                ResumeGame();
            } else
            {
                PauseGame();
            }
        }
    }

    void ResumeGame()
    {
        Cursor.lockState = CursorLockMode.Locked;
        pauseUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    void PauseGame()
    {
        Cursor.lockState = CursorLockMode.None;
        pauseUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }
    public void NavigateToMainMenu()
    {
        Debug.Log("to main menu");
        SceneManager.LoadScene(mainMenuSceen);
    }
    public void ResetGame()
    {
        Debug.Log("reset game");
        SceneManager.LoadScene(resetScene);
        ResumeGame();
    }
    public void QuitGame()
    {
        Debug.Log("quit game");
        Application.Quit();
    }
}
