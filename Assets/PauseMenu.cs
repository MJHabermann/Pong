using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool GameIsPaused;
    // Update is called once per frame
    public GameObject pauseMenuUI;
    void Start()
    {
    GameIsPaused = true;
    }

    void Update()
    {
        if(!Input.GetKey(KeyCode.H))
        {
            resume();
        }
        else
        {
            pause();
        }
    }

    void resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}


