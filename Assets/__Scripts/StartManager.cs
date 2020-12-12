using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManager : MonoBehaviour
{
    public GameObject gameMenuUI;
    public GameObject startMenuUI;
    // Start is called before the first frame update
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
