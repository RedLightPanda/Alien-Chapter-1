using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_Menu : MonoBehaviour
{
    [SerializeField]
    private GameObject _MainMenu;

    [SerializeField]
    private GameObject _OptionMenu;

    [SerializeField]
    private GameObject _SoundMenu;

    [SerializeField]
    private GameObject _VideoMenu;

    public void PlayGame()
    {
        Debug.Log("Play button Clicked");
    }

    public void Options()
    {
        _MainMenu.SetActive(false);
        _OptionMenu.SetActive(true);
    }

    public void Sound()
    {
        _OptionMenu.SetActive(false);
        _SoundMenu.SetActive(true);
    }

    public void Video()
    {
        _OptionMenu.SetActive(false);
        _VideoMenu.SetActive(true);
    }

    public void Quit()
    {
        Debug.Log("Game Quit");
        Application.Quit();
    }

    public void OptionBackButton()
    {
        _MainMenu.SetActive(true);
        _OptionMenu.SetActive(false);
    }

    public void SoundBackButton()
    {
        _SoundMenu.SetActive(false);
        _OptionMenu.SetActive(true);
    }

    public void VideoBackButton()
    {
        _VideoMenu.SetActive(false);
        _OptionMenu.SetActive(true);
    }
}
