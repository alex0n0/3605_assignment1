using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuScript : MonoBehaviour {

    public string gameScene;

    public void StartGame()
    {
        Debug.Log("start game");
        SceneManager.LoadScene(gameScene);
        Time.timeScale = 1f;
    }
    public void QuitGame()
    {
        Debug.Log("quit game");
        Application.Quit();
    }
}
