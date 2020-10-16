using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Laptop_UI : MonoBehaviour
{

    [SerializeField]
    private RawImage LaptopDesktop;

    // Start is called before the first frame update
    void Start()
    {
        LaptopDesktop.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Powerdown()
    {
        LaptopDesktop.gameObject.SetActive(false);
    }
}
