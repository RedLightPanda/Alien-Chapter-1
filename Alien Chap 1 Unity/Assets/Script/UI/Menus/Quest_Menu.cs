using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest_Menu : MonoBehaviour
{

    [SerializeField]
    private GameObject QuestMenu;
    
    [SerializeField]
    private GameObject Sub_QuestMenu;

    public void Quest()
    {
        Sub_QuestMenu.SetActive(true);
        QuestMenu.SetActive(false);
    }

    public void QuestDenided()
    {
        QuestMenu.SetActive(true);
        Sub_QuestMenu.SetActive(false);
    }

}
