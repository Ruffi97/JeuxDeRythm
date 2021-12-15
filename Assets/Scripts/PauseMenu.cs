using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused;
    public GameObject pauseMenuUI;
    public GameObject PauseFirstButton;
    public AudioSource AudioSource;

    private void Start()
    {
        GameIsPaused = false;
        Time.timeScale = 1f;
        AudioSource.Play();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (GameIsPaused)
            {
                GameIsPaused = !GameIsPaused;
                Resume();
                EventSystem.current.SetSelectedGameObject(null);
            }
            else
            {
                GameIsPaused = !GameIsPaused;
                Pause();
                EventSystem.current.SetSelectedGameObject(PauseFirstButton);
            }
        }
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        AudioSource.UnPause();
        GameIsPaused = false;
    }
    void Pause()
    {
        GameIsPaused = true;
        Time.timeScale = 0f;
        pauseMenuUI.SetActive(true);
        AudioSource.Pause();
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Hub");
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        AudioSource.Play();
    }
}