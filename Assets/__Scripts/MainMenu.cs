using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour{

public static int nextLevel = 1;
public Text levelText;
public void PlayGame()
{
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
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
