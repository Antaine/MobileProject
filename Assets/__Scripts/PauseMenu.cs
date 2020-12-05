using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject gameMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if(GameIsPaused){
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume(){
        pauseMenuUI.SetActive(false);
        gameMenuUI.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause(){
        pauseMenuUI.SetActive(true);
        gameMenuUI.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu(){
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame(){
        Debug.Log("Quit");
        Application.Quit();
    }
}
