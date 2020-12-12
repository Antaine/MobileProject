using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public Text finalScoreText;
    public GameObject nextLevelUI;
    public GameObject gameMenuUI;
    float currTime = 0f;
    float startTime = 0f;
    float distance = 0;
    public static int score =0;
    private float finalScore;
    private string player1Name = MainMenu.player1Name;

    void Update(){
        currTime += 1*Time.deltaTime;
        scoreText.text = currTime.ToString("0");
        distance = player.position.z;
        score = (int)currTime; 
        if(currTime>120)
            NextLevelMenu();
    }

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
}
