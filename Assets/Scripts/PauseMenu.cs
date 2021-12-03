using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;
    public GameObject PauseFirstButton;
    public AudioSource AudioSource;
    public AudioClip test;

    private void Start()
    {
        AudioSource.clip = test;
        AudioSource.Play();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
                EventSystem.current.SetSelectedGameObject(null);
            }
            else
            {
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
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        AudioSource.clip = test;
        AudioSource.Pause();
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Hub");
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        AudioSource.clip = test;
        AudioSource.Play();
    }
}