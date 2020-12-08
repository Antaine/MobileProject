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
    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
        if(player.position.z>100){
            NextLevelMenu();
        }
    }

    
    public void NextLevelMenu(){
        Time.timeScale = 0f;
        gameMenuUI.SetActive(false);
        nextLevelUI.SetActive(true);
    }


}
