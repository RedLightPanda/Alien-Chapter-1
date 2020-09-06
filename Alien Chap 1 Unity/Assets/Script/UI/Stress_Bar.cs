using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stress_Bar : MonoBehaviour
{

    public Slider slider;

   public void SetMaxStress(int Stress)
    {
        slider.maxValue = Stress;
        slider.value = Stress;
    }

    public void SetStress(int Stress)
    {
        slider.value = Stress;
    }
}
