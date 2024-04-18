using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GUIDialog : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    private string[] dialogs = new string[0];
    [SerializeField] private GameObject downArrow;
    private int index = 0;

    private void Start()
    {
        downArrow.SetActive(false);
    }

    private void Update()
    {
        if(dialogs.Length > 0)
        {
            text.text = dialogs[index];
        }

        if(index == dialogs.Length - 1)
        {
            downArrow.SetActive(false);
        }

        if(index < dialogs.Length - 1)
        {
            downArrow.SetActive(true);
        }
    }

    public void LoadDialogs(string[] dialogs)
    {
        this.dialogs = dialogs;
    }

    public void IncreaseIndex()
    {
        Debug.Log("Index: " + index);
        Debug.Log("Dialogs: " + dialogs.Length);
        if(index < dialogs.Length - 1)
        {
            index+=1;
        }
    }
}
