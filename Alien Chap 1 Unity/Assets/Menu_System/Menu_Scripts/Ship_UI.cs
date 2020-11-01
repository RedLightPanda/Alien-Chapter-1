using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ship_UI : MonoBehaviour
{
    //HP Bar
    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
