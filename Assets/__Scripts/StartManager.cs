using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Starts Game After Tap
/// </summary>
public class StartManager : MonoBehaviour
{
    public GameObject gameMenuUI;
    public GameObject startMenuUI;

    void Update()
    {
        if(SwipeManager.tap)
        {
            FindObjectOfType<AudioManager>().Play("ClickSound");
            Time.timeScale = 1f;
            startMenuUI.SetActive(false);
            gameMenuUI.SetActive(true);
        }
    }
}
