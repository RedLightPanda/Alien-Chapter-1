using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InShip_Colliders : MonoBehaviour
{

    bool InteractAllowed;

    [SerializeField]
    private bool NPCTrigger;
  
    [SerializeField]
    private bool Doors;

    public GameObject Door, Player;

    DialogueTrigger dialogue;

    Laptop_UI laptop;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
        if (NPCTrigger && InteractAllowed && Input.GetKeyDown(KeyCode.Space))
        {
            Dialog();
        }

        if (Doors && InteractAllowed && Input.GetKeyDown(KeyCode.Space))
        {
            Test2D();
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            InteractAllowed = true;
        }


    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            InteractAllowed = false;
        }
    }

       void Test2D()
    {
        Debug.Log("Ya it's working chef");
        TestDoor();
    }

    void TestDoor()
    {
        Player.transform.position = new Vector2(Door.transform.position.x, Door.transform.position.y);
    }

    void Dialog()
    {
        Debug.Log("Ya Ya I'm talking wee...Now set up the real system dumbass");
    }

}

