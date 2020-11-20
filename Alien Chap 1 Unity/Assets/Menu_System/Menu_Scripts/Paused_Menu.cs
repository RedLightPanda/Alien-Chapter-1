using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Paused_Menu : MonoBehaviour
{

    public GameObject Options,Pause;

    public string MainMenu;

    private bool isPause;

    public GameObject loadingScreen, LoadIcon;
    public Text loadText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseUnpause();
        }  
    }

    public void PauseUnpause()
    {
        if (!isPause)
        {
            Pause.SetActive(true);
            isPause = true;

            Time.timeScale = 0;
        }
        else
        {
            Pause.SetActive(false);
            isPause = false;

            Time.timeScale = 1;
        }
    }

    public void OpenOption()
    {
        Options.SetActive(true);
    }

    public void ClosedOption()
    {
        Options.SetActive(false);
    }

    public void QuitMain()
    {
        //SceneManager.LoadScene(MainMenu);

        //Time.timeScale = 1;

        StartCoroutine(Loadmain());
    }

    public IEnumerator Loadmain()
    {
        loadingScreen.SetActive(true);

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(MainMenu);

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
