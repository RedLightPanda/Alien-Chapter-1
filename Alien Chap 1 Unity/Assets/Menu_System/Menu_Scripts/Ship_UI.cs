using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ship_UI : MonoBehaviour
{
    //HP Bar
    public Slider health;

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
        health.maxValue = Health;
        health.value = Health;
    }

    public void SetHealth(int Health)
    {
        health.value = Health;
    }

    public void SetMaxCharge(int Charge)
    {
        charge.maxValue = Charge;
        charge.value = Charge;
    }

    public void SetCharge (int Charge)
    {
        charge.value = Charge;
    }
}
