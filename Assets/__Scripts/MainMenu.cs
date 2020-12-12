using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;

public class MainMenu : MonoBehaviour{

public static int nextLevel = 1;
public Text levelText;
public Text playerName;
public static string player1Name = "";
public static int counter =0;
public AudioMixer audioMixer;

void Start(){
    FindObjectOfType<AudioManager>().Play("MenuMusic");
    if(SceneManager.GetActiveScene().buildIndex == 1 && counter ==0){
        playerName.text = player1Name;
        counter++;
    }
}
public void PlayGame(){
    player1Name = playerName.text;
    Debug.Log(player1Name);
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +nextLevel);
    nextLevel = 0;
}

public void LoadLevel(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +nextLevel);
    FindObjectOfType<AudioManager>().Pause("MenuMusic");
    FindObjectOfType<AudioManager>().Play("Level1Music");
}

public void SetLevelOffice(){
    nextLevel =1;
    levelText.text = "Level: Office";
}

public void SetLevelKitchen(){
    nextLevel = 2;
    levelText.text = "Level: Kitchen";
}

public void SetLevelCity(){
    nextLevel =3;
    levelText.text = "Level: City";
}

public void QuitGame(){
    Debug.Log("Quit");
    Application.Quit();

}

public void LoadMenu(){
    SceneManager.LoadScene(0);
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
public void SetVolume(float volume){
    audioMixer.SetFloat("Volume",volume);
}
}
