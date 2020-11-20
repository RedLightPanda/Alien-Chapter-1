using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Main_Menu : MonoBehaviour
{
    public string firstLevel;

    public GameObject optionsMenu;

    public GameObject loadingScreen, LoadIcon;
    public Text loadText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        //Debug.Log("Game Start");
        //SceneManager.LoadScene(firstLevel);

        StartCoroutine(LoadStart());
    }

    public void OpenOptions()
    {
        optionsMenu.SetActive(true);
    }

    public void CloseOptions()
    {
        optionsMenu.SetActive(false);
    }

    public void Quitgame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public IEnumerator LoadStart()
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(firstLevel);

        asyncLoad.allowSceneActivation = false;

        while (!asyncLoad.isDone)
        {
            if (asyncLoad.progress >= .9f)
            {
                loadText.text = "Press E key to continue";
                LoadIcon.SetActive(false);

                if (Input.GetKeyDown(KeyCode.E))
                {
                    asyncLoad.allowSceneActivation = true;

                    Time.timeScale = 1f;
                }
            }

            yield return null;
        }
    }
}
