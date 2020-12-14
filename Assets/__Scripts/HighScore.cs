using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// Loads High Score on Pannel
/// </summary>
public class HighScore : MonoBehaviour
{
    int highscore =0;
    string highName = "";
    public Text scoreText;
    public Text scoreName;

    //Gets Score From Game
    public void getScore(){
        highscore = PlayerPrefs.GetInt("HighScore", 0);
        highName = PlayerPrefs.GetString("HighScoreName","");
        scoreText.text = highscore.ToString();
        scoreName.text = highName;
    }
}
