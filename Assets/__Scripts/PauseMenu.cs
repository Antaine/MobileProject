using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject gameMenuUI;
    public GameObject gameOverUI;
    public GameObject startGameUI;


    // Update is called once per frame
    void Start(){
        Time.timeScale = 0f;
        startGameUI.SetActive(true);
    }
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

    public void Pause(){
        pauseMenuUI.SetActive(true);
        gameMenuUI.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu(){
        SceneManager.LoadScene("MainMenu");
    }

    public void Replay(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        gameMenuUI.SetActive(true);
        gameOverUI.SetActive(false);
    }

    public void QuitGame(){
        Debug.Log("Quit");
        Application.Quit();
    }

    public void LoadNextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }

    public void ClickSound(){
    FindObjectOfType<AudioManager>().Play("ClickSound");
    }

    public void InputSound(){
    FindObjectOfType<AudioManager>().Play("InputSound");
    }

    public void SliderSound(){
    FindObjectOfType<AudioManager>().Play("SliderSound");
    }
}
