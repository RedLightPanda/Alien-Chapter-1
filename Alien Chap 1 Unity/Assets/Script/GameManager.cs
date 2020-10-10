using System.Collections;
using System.Collections.Generic;
using UI_Driver;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;
    public static UI_Driver_System UI = null;

    // Start is called before the first frame update
    void Start()
    {
        if (instance && UI == null)
        {
            instance = this;
            UI = UI_Driver ;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
