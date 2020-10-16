using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class UI_Menus : MonoBehaviour
{
  [MenuItem("UI Tools/Create/UI Group")]
  public static void CreateUIGroup()
    {
        //  Debug.Log("Creating UI Group");
        GameObject uiGroup = AssetDatabase.LoadAssetAtPath<GameObject>("Assets/Prefabs/UI/UI_Group.prefab");
        if (uiGroup)
        {
            GameObject createGroup = (GameObject)Instantiate(uiGroup);
            createGroup.name = "UI_Group";
        }
        else
        {
            EditorUtility.DisplayDialog("Couldn't find what you where looking for sorry.", "There's no one home boss.", "OK");
        }
    }
}
