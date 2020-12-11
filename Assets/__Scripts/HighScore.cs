using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    // Start is called before the first frame update
    int highscore =0;
    string highName = "";
    public Text scoreText;
    public Text scoreName;
    public void getScore(){
        highscore = PlayerPrefs.GetInt("HighScore", 0);
        highName = PlayerPrefs.GetString("HighScoreName","");
        scoreText.text = highscore.ToString();
        scoreName.text = highName;
       // Debug.Log("High Score Name in getScore");
        //Debug.Log(PlayerPrefs.GetString("HighScoreName",""));

    }
}
