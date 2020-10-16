using System.Collections;
using System.Collections.Generic;
using UI_Screens;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.Audio;
using UnityEngine.Events;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

namespace UI_Driver
{
    public class UI_Driver_System : MonoBehaviour
    {
        #region Variable
        [Header("Main Properties")]
        public UI_Screen_System StartScreen;

        [Header("System Events")]
        public UnityEvent onSwitchedScreen = new UnityEvent();

        [Header("Fader Properties")]
        public Image Fade;
        public float fadeInDuration = 1f;
        public float fadeOutDuration = 1f;
       
        //HP
        public Slider slider;
       
        // Audio
        public AudioMixer MasterVolume;

        //Pause
        public static bool GamePaused = false;

        public Component[] screens = new Component[0];
                
        private UI_Screen_System previousScreen;
        public UI_Screen_System PreviousScreen {get{return previousScreen;}}

        private UI_Screen_System currentScreen;
        public UI_Screen_System CurrentScreen {get{return currentScreen;}}
        #endregion

        #region Main_Script

        // Start is called before the first frame update
        void Start()
        {
            screens = GetComponentsInChildren<UI_Screen_System>(true);
           // InitializeScreens();

            if (StartScreen)
            {
                SwitchScreens(StartScreen);
            }
            if (Fade)
            {
                Fade.gameObject.SetActive(true);
            }
            FadeIn();
        }
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

        #endregion

        #region Helper Code
        public void SwitchScreens(UI_Screen_System aScreen)
        {
            if (aScreen)
            {
                if (currentScreen)
                {
                    currentScreen.CloseScreen();
                    previousScreen = currentScreen;
                }
                currentScreen = aScreen;
                currentScreen.gameObject.SetActive(true);
                currentScreen.StartScreen();

                if(onSwitchedScreen != null)
                {
                    onSwitchedScreen.Invoke();
                }
            }
        }

        public void FadeIn()
        {
            if (Fade)
            {
                Fade.CrossFadeAlpha(0f, fadeInDuration, false);
            }
        }

        public void FadeOut()
        {
            if (Fade)
            {
                Fade.CrossFadeAlpha(1f, fadeOutDuration, false);
            }
        }

        public void GoToPreviousScreen()
        {
            if (previousScreen)
            {
                SwitchScreens(previousScreen);
            }
        }

        public void LoadScene(int sceneIndex)
        {
            StartCoroutine(WaitToLoadScene(sceneIndex));
        }

        IEnumerator WaitToLoadScene(int sceneIndex)
        {
            yield return null;
        }

        //void InitializeScreens()
        //{
        //    foreach (var screen in screens)
        //    {
        //        screen.gameObject.SetActive(true);
        //    }
        //}

        public void SetVolume(float volume)
        {
            Debug.Log(volume);

            MasterVolume.SetFloat("Master Volume", volume);
        }

        public void SetQuality(int qualityIndex)
        {
            QualitySettings.SetQualityLevel(qualityIndex);
        }

        public void SetFullscreen(bool isFullscreen)
        {
            Screen.fullScreen = isFullscreen;
        }

        public void Resume()
        {
            
            Time.timeScale = 1f;
            GamePaused = false;
        }

        public void Pause()
        {
            
            Time.timeScale = 0f;
            GamePaused = true;
        }

        public void SetMaxHealth(int Health)
        {
            slider.maxValue = Health;
            slider.value = Health;
        }

        public void SetHealth(int Health)
        {
            slider.value = Health;
        }

        public void Play()
        {
            SceneManager.LoadScene(1);
            Debug.Log("Play");
        }

         public void Exit()
         {
         Debug.Log("Has Quit");
         Application.Quit();
         }
        #endregion
    }

}
 //This holds everything for the UI system use with care.
