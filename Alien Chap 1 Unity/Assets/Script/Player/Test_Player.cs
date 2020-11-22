//using System.Collections;
//using System.Collections.Generic;

//using UnityEngine;

//public class Test_Player : MonoBehaviour
//{
//    public int maxStress = 100;
//    public int CurrentStress;
//    public int maxHealth = 100;
//    public int CurrentHealth;
//    public Stress_Bar stressBar;
//    // Start is called before the first frame update
//    void Start()
//    {
//        CurrentStress = 0;
//        stressBar.SetStress(CurrentStress);

//        CurrentHealth = 100;
//        healthBar.SetHealth(maxHealth);
//    }

//    // Update is called once per frame
//    void Update()
//    {


//    }

//    public void addStress()
//    {
//        TakeStress(10);
//    }

//    public void removeStress()
//    {
//        RemoveStress(10);
//    }

//    void TakeStress(int stress)
//    {
//        CurrentStress += stress;
//        stressBar.SetStress(CurrentStress);
//    }

//    void RemoveStress(int stress)
//    {
//        CurrentStress -= stress;
//        stressBar.SetStress(CurrentStress);
//    }

//    public void takeDamage()
//    {
//        TakeDamage(10);
//    }

//    public void addHealth()
//    {
//        AddHealth(10);
//    }

//    //void TakeDamage (int Health)
//    //{
//    //    CurrentHealth -= Health;
//    //    healthBar.SetHealth(CurrentHealth);

//    //}

//    //void AddHealth (int Health)
//    //{
//    //    CurrentHealth += Health;
//    //    healthBar.SetHealth(CurrentHealth);
//    //}
//}
