using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Audio;
/// <summary>
/// Manages Menu Navigation and Loading levels/Music
/// </summary>
public class MainMenu : MonoBehaviour{

public static int nextLevel = 0;
public Text levelText;
public Text playerName;
public static string player1Name = "";
public static int counter =0;
public AudioMixer audioMixer;

//Play Music and get Player Name
void Start(){
    FindObjectOfType<AudioManager>().Play("MenuMusic");
    playerName.text = player1Name;
}

//Loads a Scene
public void LoadLevel(){
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +nextLevel);
    FindObjectOfType<AudioManager>().Pause("MenuMusic");
    FindObjectOfType<AudioManager>().Play("Level1Music");
}

//Selects Office Level
public void SetLevelOffice(){
    nextLevel =2;
    levelText.text = "Level: Office";
}
//Selects Kitchen Level
public void SetLevelKitchen(){
    nextLevel = 3;
    levelText.text = "Level: Kitchen";
}
//Seleccts City Level
public void SetLevelCity(){
    nextLevel =4;
    levelText.text = "Level: City";
}
//Selects Multiplayer Scene
public void SetLevelMulti(){
    nextLevel =1;
    levelText.text = "Level: Office M";
}
//Ends Game
public void QuitGame(){
    Debug.Log("Quit");
    Application.Quit();

}
//Loads Menu
public void LoadMenu(){
    SceneManager.LoadScene(0);
}
//Click Sound
public void ClickSound(){
    FindObjectOfType<AudioManager>().Play("ClickSound");
}
//Input bar Sounds
public void InputSound(){
    FindObjectOfType<AudioManager>().Play("InputSound");
}
//Slider Sound
public void SliderSound(){
    FindObjectOfType<AudioManager>().Play("SliderSound");
}
//Sets Volume
public void SetVolume(float volume){
    audioMixer.SetFloat("Volume",volume);
}
//Saves Player Name
public void GetPlayerName(string name){
    player1Name = name;
    playerName.text = player1Name;
}
}
