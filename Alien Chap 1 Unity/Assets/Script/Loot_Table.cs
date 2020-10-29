using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot_Table : MonoBehaviour
{
    public List<GameObject> lights;
    public int[] table = 
        {
        60, //Gem A
        30,  //Gem B
        10    //Gem C
        };

    public int total;
    public int RandomNum;
    // Start is called before the first frame update
    void Start()
    {
        //tally Total
        //draw a random #.

        foreach (var item in table)
        {
            total += item;
        }

        RandomNum = Random.Range(0, total);


           // Compare numbers to Table.
       for(int i = 0; i <table.Length; i++)
       {
         if (RandomNum <= table[i])
         {
           lights[i].SetActive(true);
           return;
         }
         else
         {
           RandomNum -= table[i];
         }
       }
    }
}
