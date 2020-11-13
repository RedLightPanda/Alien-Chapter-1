using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ship_UI : MonoBehaviour
{
    //HP Bar
    public Slider slider;

    //Charge counter
    public Slider charge;

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

    public void SetMaxCharge(int Charge)
    {
        slider.maxValue = Charge;
        slider.value = Charge;
    }

    public void SetCharge (int Charge)
    {
        slider.value = Charge;
    }
}
