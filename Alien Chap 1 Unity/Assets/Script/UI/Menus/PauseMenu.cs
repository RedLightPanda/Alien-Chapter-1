using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePaused = false;

    public GameObject PauseUI;

    public GameObject OptionUI;

    public GameObject AbortUI;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;
    }

    void Pause()
    {
        PauseUI.SetActive(true);
        Time.timeScale = 0f;
        GamePaused = true;
    }

   public void Option()
    {
        OptionUI.SetActive(true);
        PauseUI.SetActive(false);
    }

    public void Back()
    {
        OptionUI.SetActive(false);
        PauseUI.SetActive(true);
    }
    
    
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Abort()
    {
        PauseUI.SetActive(false);
        AbortUI.SetActive(true);
    }

    public void NoAbort()
    {
        AbortUI.SetActive(false);
        PauseUI.SetActive(true);
    }

    public void YesAbort()
    {
        Debug.Log("Mission Aborted");
    }

    public void Quit()
    {
        Debug.Log("Quitting");
        Application.Quit();
    }

}
