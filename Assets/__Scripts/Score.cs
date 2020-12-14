using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
/// <summary>
/// Updates Score based on Time and Detects When Level is Complete
/// </summary>
public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text finalScoreText;
    public GameObject nextLevelUI;
    public GameObject gameMenuUI;
    float currTime = 0f;
    float distance = 0;
    public static int score =0;
    private int timeNeeded = 120;
    private float finalScore;
    private string player1Name = MainMenu.player1Name;

//Gets Time and checks for win condition
    void Update(){
        currTime += 1*Time.deltaTime;
        scoreText.text = currTime.ToString("0");
        distance = player.position.z;
        score = (int)currTime; 
        if(currTime>timeNeeded)
            NextLevelMenu();
    }
//Loads Next Level
    public void NextLevelMenu(){
        FindObjectOfType<AudioManager>().Play("VictorySound");
        finalScoreText.text = score.ToString("0");
        if(score > PlayerPrefs.GetInt("HighScore", 0)){
            PlayerPrefs.SetInt("HighScore", score);
            PlayerPrefs.SetString("HighScoreName",player1Name);
        }
        
        Time.timeScale = 0f;
        gameMenuUI.SetActive(false);
        nextLevelUI.SetActive(true);
    }
//Resumes Level
    public void AddTime(){
        timeNeeded = 99999;
    }
}
