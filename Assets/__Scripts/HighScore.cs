using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    // Start is called before the first frame update
    int highscore =0;
    public Text scoreText;
    public void getScore(){
        highscore = PlayerPrefs.GetInt("HighScore", 0);
        scoreText.text = highscore.ToString();
    }
}
