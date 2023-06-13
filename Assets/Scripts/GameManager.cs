using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject pauseMenu;
    public bool paused;
    void Start()
    {
        paused = false;
        Time.timeScale = 0f;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            ChangePaused();
        }

    }
    public void Play()
    {
        mainMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    void ChangePaused()
    {
        
        if (!paused)
        {
            paused = true;
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
        else
        {
            paused = false;
            pauseMenu.SetActive(false);
            Time.timeScale = 1;

        }
    }
    
}
