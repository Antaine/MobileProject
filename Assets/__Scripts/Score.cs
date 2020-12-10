using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public GameObject nextLevelUI;
    public GameObject gameMenuUI;
    float currTime = 0f;
    float startTime = 0f;
    float distance = 0;
    // Update is called once per frame
    void Update()
    {
        currTime += 1*Time.deltaTime;
        Debug.Log(currTime);
        scoreText.text = currTime.ToString("0");
        distance = player.position.z;
        if(currTime>120){
            NextLevelMenu();
        }
    }

    
    public void NextLevelMenu(){
        Time.timeScale = 0f;
        gameMenuUI.SetActive(false);
        nextLevelUI.SetActive(true);
    }


}
