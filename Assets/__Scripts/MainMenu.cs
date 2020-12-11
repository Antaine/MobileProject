using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour{

public static int nextLevel = 1;
public Text levelText;
public Text playerName;
public static string player1Name = "";
public static int counter =0;

void Start(){
    if(SceneManager.GetActiveScene().buildIndex == 1 && counter ==0){
        Debug.Log("Lobby Loaded");
        playerName.text = player1Name;
        counter++;
    }
}
public void PlayGame()
{
    player1Name = playerName.text;
    Debug.Log(player1Name);
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +nextLevel);
    nextLevel = 0;
}

public void LoadLevel()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +nextLevel);
}

public void SetLevelOffice()
{
    nextLevel =1;
    levelText.text = "Level: Office";
}

public void SetLevelKitchen()
{
    nextLevel = 2;
    levelText.text = "Level: Kitchen";
}

public void SetLevelCity()
{
    nextLevel =3;
    levelText.text = "Level: City";
}

public void QuitGame()
{
    Debug.Log("Quit");
    Application.Quit();

}

}
