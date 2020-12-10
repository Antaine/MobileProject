using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update
public static bool gameOver;
public static int score;
[SerializeField] float loadDelay = 2.0f;
public GameObject gameMenuUI;
public GameObject gameOverMenuUI;
public Text finalScoreText;
int finalScore =0;
public static bool shielded = false;
    void Start()
    {
        gameOver = false;
        shielded = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameOver)
        {
            DeathScreen();
        }
    }

    public void DeathScreen(){
        finalScore = Score.score;
        Debug.Log(finalScore);
        finalScoreText.text = finalScore.ToString("0");
        if(finalScore > PlayerPrefs.GetInt("HighScore", 0)){
            PlayerPrefs.SetInt("HighScore", finalScore);
        }
        gameOverMenuUI.SetActive(true);
        gameMenuUI.SetActive(false);
        Time.timeScale = 0f;
    }


}
