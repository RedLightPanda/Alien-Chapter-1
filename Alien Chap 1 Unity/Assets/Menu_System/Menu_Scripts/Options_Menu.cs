using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Options_Menu : MonoBehaviour
{
    public Toggle FullScreenTog, VsyncTog;

    public ResItem[] resolution;

    public int selectedRes;

    public Text resLable;

    public AudioMixer theMixer;

    public Slider masterSlide, musicSlide, sfxSlide;
    public Text mastLable, musicLable, sfxLable;

    public AudioSource SFXLoop;

    // Start is called before the first frame update
    void Start()
    {
        FullScreenTog.isOn = Screen.fullScreen;
        
        if(QualitySettings.vSyncCount == 0)
        {
            VsyncTog.isOn = false;
        }
        else
        {
            VsyncTog.isOn = true;
        }

        //secrch for Res
        bool foundRes = false;
        for (int i = 0; i < resolution.Length; i++)
        {
            if(Screen.width == resolution[i].horizontal && Screen.height == resolution[i].vertical)
            {
                foundRes = true;

                selectedRes = i;

                UpdateResLabel();
            }
        }

        if (!foundRes)
        {
            resLable.text = Screen.width.ToString() + "x" + Screen.height.ToString();
        }

        if (PlayerPrefs.HasKey("Master"))
        {
            theMixer.SetFloat("Master", PlayerPrefs.GetFloat("Master"));
            masterSlide.value = PlayerPrefs.GetFloat("Master");
            
        }

        if (PlayerPrefs.HasKey("Music"))
        {
            theMixer.SetFloat("Music", PlayerPrefs.GetFloat("Music"));
            musicSlide.value = PlayerPrefs.GetFloat("Music");
          
        }

        if (PlayerPrefs.HasKey("SFX"))
        {
            theMixer.SetFloat("SFX", PlayerPrefs.GetFloat("SFX"));
            sfxSlide.value = PlayerPrefs.GetFloat("SFX");
            
        }
        mastLable.text = (masterSlide.value + 80).ToString();
        musicLable.text = (musicSlide.value + 80).ToString();
        sfxLable.text = (sfxSlide.value + 80).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void ResLeft()
    {
        selectedRes--;
        if(selectedRes < 0)
        {
            selectedRes = 0;
        }

        UpdateResLabel();
    }

    public void ResRight()
    {
        selectedRes++;
        if(selectedRes > resolution.Length-1) 
        {
            selectedRes = resolution.Length - 1;
        }

        UpdateResLabel();
    }

    public void UpdateResLabel()
    {
        resLable.text = resolution[selectedRes].horizontal.ToString() + "x" + resolution[selectedRes].vertical.ToString();
    }

    public void ApplyGraphics()
    {
        //apply fullscreen
        //Screen.fullScreen = FullScreenTog.isOn;

        if (VsyncTog.isOn)
        {
            QualitySettings.vSyncCount = 1;
        }
        else
        {
            QualitySettings.vSyncCount = 0;
        }

        //set resolution
        Screen.SetResolution(resolution[selectedRes].horizontal, resolution[selectedRes].vertical, FullScreenTog.isOn);
    }

    public void SetMasterVol()
    {
        mastLable.text = (masterSlide.value + 80).ToString();

        theMixer.SetFloat("Master", masterSlide.value);

        PlayerPrefs.SetFloat("Master", masterSlide.value);
    }

    public void SetMusic()
    {
        musicLable.text = (musicSlide.value + 80).ToString();

        theMixer.SetFloat("Music", musicSlide.value);

        PlayerPrefs.SetFloat("Music", musicSlide.value);
    }

    public void SetSFX()
    {
        sfxLable.text = (sfxSlide.value + 80).ToString();

        theMixer.SetFloat("SFX", sfxSlide.value);

        PlayerPrefs.SetFloat("SFX", sfxSlide.value);
    }

    public void PlaySFX()
    {
        SFXLoop.Play();
    }

    public void StopSFX()
    {
        SFXLoop.Stop();
    }
}



[System.Serializable]
public class ResItem
{
    public int horizontal, vertical;

}