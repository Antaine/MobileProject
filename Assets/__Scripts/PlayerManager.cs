using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static bool gameOver;
    [SerializeField] float loadDelay = 2.0f;
    public GameObject gameMenuUI;
    public GameObject gameOverMenuUI;
    public Text finalScoreText;
    private string player1Name = MainMenu.player1Name;
    public static bool shielded = false;
    public Image shieldSprite;

    void Start(){
        gameOver = false;
        shielded = false;
    }

    void Update(){
        if(gameOver)
            DeathScreen();
            gameOver = false;

        if(shielded == true)
            shieldSprite.enabled = true;

        else if(!shielded)
            shieldSprite.enabled = false;
    }

    public void DeathScreen(){
        FindObjectOfType<AudioManager>().Play("PlayerDeath");
        finalScoreText.text = Score.score.ToString("0");
        if(Score.score > PlayerPrefs.GetInt("HighScore", 0)){
            PlayerPrefs.SetInt("HighScore", Score.score);
            PlayerPrefs.SetString("HighScoreName",player1Name);
        }
        gameOverMenuUI.SetActive(true);
        gameMenuUI.SetActive(false);
        Time.timeScale = 0f;  
    }
}
