using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InShip_Colliders : MonoBehaviour
{

    bool InteractAllowed;

    //[SerializeField]
    //private bool LaptopTrigger;

    //[SerializeField]
    //private bool SavePointTrigger;

    [SerializeField]
    private bool NPCTrigger;

    //[SerializeField]
    //private bool ShipMat;

    //[SerializeField]
    //private Text PressE;

    //[SerializeField]
    //private Image DialogueBox;

    //[SerializeField]
    //private RawImage LaptopDesktop;

    [SerializeField]
    private bool Doors;

    public GameObject Door, Player;

    DialogueTrigger dialogue;

    Laptop_UI laptop;

    // Start is called before the first frame update
    void Start()
    {
        //PressE.gameObject.SetActive(false);
        //DialogueBox.gameObject.SetActive(false);
        //LaptopDesktop.gameObject.SetActive(false);
        //dialogue = GetComponent<DialogueTrigger>();
        //laptop = GetComponent<Laptop_UI>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (LaptopTrigger && InteractAllowed && Input.GetKeyDown(KeyCode.E))
        //{
        //    Laptop();
        //}

        //if (SavePointTrigger && InteractAllowed && Input.GetKeyDown(KeyCode.E))
        //{
        //    SavePoint();
        //}

        if (NPCTrigger && InteractAllowed && Input.GetKeyDown(KeyCode.E))
        {
            Dialog();
        }

        //if (ShipMat && InteractAllowed && Input.GetKeyDown(KeyCode.E))
        //{
        //    ShipScreen();
        //}

        if (Doors && InteractAllowed && Input.GetKeyDown(KeyCode.E))
        {
            Test2D();
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //PressE.gameObject.SetActive(true);
            InteractAllowed = true;

        }


    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //PressE.gameObject.SetActive(false);
            InteractAllowed = false;
        }
    }

    //    void Laptop()
    //    {
    //    InteractAllowed = false;
    //    PressE.gameObject.SetActive(false);
    //    LaptopDesktop.gameObject.SetActive(true);
    //    }

    //    void SavePoint()
    //    {
    //        Debug.Log("Saved");
    //    }

    //    void NPC()
    //    {
    //        InteractAllowed = false;
    //        PressE.gameObject.SetActive(false);
    //        DialogueBox.gameObject.SetActive(true);
    //        dialogue.TriggerDialogue();
    //    }

    //    void ShipScreen()
    //    {
    //        Debug.Log("Ship work");
    //    }


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

