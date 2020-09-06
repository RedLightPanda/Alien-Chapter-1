using System.Collections;
using System.Collections.Generic;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer MasterVolume;


    public void SetVolume(float volume)
    {
        Debug.Log(volume);

        MasterVolume.SetFloat("Master Volume", volume);
    }

    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen (bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
    }
}
