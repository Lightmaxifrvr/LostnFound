using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using UnityEngine.SceneManagement;



public class PauseMenu : MonoBehaviour

{

    public static bool GameIsPaused = false;



    public GameObject pauseMenuUI;
    public string MenuScene;



    void Update()

    {

        if (Input.GetButtonDown("Menu"))

        {

            if (GameIsPaused)

            {

                Resume();

            } else

            {

                Pause();

            }

        }

    }



    public void Resume ()

    {

        pauseMenuUI.SetActive(false);

        Time.timeScale = 1f;

        GameIsPaused = false;

        Cursor.visible = false;

        Cursor.lockState = CursorLockMode.Locked;

    }

    public void Pause ()

    {

        pauseMenuUI.SetActive(true);

        Time.timeScale = 0f;

        GameIsPaused = true;

        Cursor.lockState = CursorLockMode.None;

        Cursor.visible = true;

    }



    public void LoadMenu()



    {

        Time.timeScale = 1f;

        SceneManager.LoadScene(MenuScene);
        
        GameIsPaused = false;
    }



    public void QuitGame()

    {

        Debug.Log("Quitting game...");

        Application.Quit();

    }



    public void Reload()

    {

        Debug.Log("Reloading ...");

        Time.timeScale = 1f;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

}