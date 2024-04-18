using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GUIDialog : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] private GameObject downArrow;
    private string[] dialogs = new string[0];
    private int index = 0;

    [SerializeField] private Assistant assistant;

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

        if (index < dialogs.Length - 1)
        {
            downArrow.SetActive(true);
        }
        else
        {
            downArrow.SetActive(false);
        }
    }

    public void LoadDialogs(string[] dialogs)
    {
        index = 0;
        this.dialogs = dialogs;
    }

    public void IncreaseIndex()
    {
        if(index < dialogs.Length - 1)
        {
            index+=1;
        }
        assistant.IncreaseIndex();
    }
}
