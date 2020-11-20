using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{

    public AudioMixer theMixer;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("Master"))
        {
            theMixer.SetFloat("Master", PlayerPrefs.GetFloat("Master"));
        }

        if (PlayerPrefs.HasKey("Music"))
        {
            theMixer.SetFloat("Music", PlayerPrefs.GetFloat("Music"));
        }

        if (PlayerPrefs.HasKey("SFX"))
        {
            theMixer.SetFloat("SFX", PlayerPrefs.GetFloat("SFX"));
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
