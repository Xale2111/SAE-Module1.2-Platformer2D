using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;

    private void Start()
    {
        pauseMenu.SetActive(false);
    }

    public void InversePauseState()
    {
        pauseMenu.SetActive(!pauseMenu.activeSelf);

        if (pauseMenu.activeSelf)
        {
            PauseGame();
        }
        else
        {
            UnPauseGame();
        }
    }

    private void PauseGame()
    {
        Time.timeScale = 0;
        pauseMenu.SetActive(true);
    }

    private void UnPauseGame()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }
    
    public void Resume()
    {
        UnPauseGame();   
    }
    
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
        UnPauseGame();
    }
    
    public void Quit()
    {
        UnPauseGame();
        Application.Quit();        
    }
    
    
}
