using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause_N_GameOverMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    
    public GameObject pauseMenuUI;
    public GameObject gameOverMenuUI;
    public GameObject winMenuUI;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }

        }


        GameOver();
        Win();
        TimeUp();
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);

    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void GameOver()
    {
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHP>().currentHP <= 0)
        {
            Time.timeScale = 0f;
            gameOverMenuUI.SetActive(true);
        }
    }

    public void TimeUp()
    {
        if (GameObject.FindGameObjectWithTag("UI").GetComponent<InGameUI>().remainingTime<= 0)
        {
            Time.timeScale = 0f;
            gameOverMenuUI.SetActive(true);
        }
    }



    public void Win()
    {
        if (GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().CollectedObj_Num >= 7)
        {
            Time.timeScale = 0f;
            winMenuUI.SetActive(true);
        }
    }

}