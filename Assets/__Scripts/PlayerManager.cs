using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    // Start is called before the first frame update
public static bool gameOver;
[SerializeField] float loadDelay = 2.0f;
public GameObject gameMenuUI;
public GameObject gameOverMenuUI;
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
        gameOverMenuUI.SetActive(true);
        gameMenuUI.SetActive(false);
        Time.timeScale = 0f;
    }


}
