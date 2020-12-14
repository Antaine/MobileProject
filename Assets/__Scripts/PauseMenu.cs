using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

///Controls Menus, Navigation and Manages Time in Game/// 
public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject gameMenuUI;
    public GameObject gameOverUI;
    public GameObject startGameUI;
    public AudioMixer audioMixer;
    // Pauses Game
    void Start(){
        Time.timeScale = 0f;
        startGameUI.SetActive(true);
    }
    //Pauses Game on P key
    void Update(){
        if (Input.GetKeyDown(KeyCode.P))
        {
            if(GameIsPaused)
                Resume();
            else
                Pause();
        }
    }
    //Plays the Game
    public void Resume(){
        pauseMenuUI.SetActive(false);
        gameMenuUI.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    //Pauses the Game
    public void Pause(){
        pauseMenuUI.SetActive(true);
        gameMenuUI.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    //Loads Main Menu
    public void LoadMenu(){
        SceneManager.LoadScene("MainMenu");
    }
    //Restarts Level
    public void Replay(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
        gameMenuUI.SetActive(true);
        gameOverUI.SetActive(false);
    }
    //Quits Game after build
    public void QuitGame(){
        Debug.Log("Quit");
        Application.Quit();
    }
    //Loads Next Level
    public void LoadNextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    //Plays Click Sound
    public void ClickSound(){
    FindObjectOfType<AudioManager>().Play("ClickSound");
    }
    //Plays Input Sound
    public void InputSound(){
    FindObjectOfType<AudioManager>().Play("InputSound");
    }
    //Slider Sounds
    public void SliderSound(){
    FindObjectOfType<AudioManager>().Play("SliderSound");
    }
    //Sets Volume
    public void SetVolume(float volume){
    audioMixer.SetFloat("Volume",volume);
}
}
