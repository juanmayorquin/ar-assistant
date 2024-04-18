using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GUIButton : MonoBehaviour
{
    [SerializeField] private GameObject menuPanel;
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] GUIDialog guiDialog;
    [SerializeField] string[] dialogs;
    [SerializeField] AudioClip[] audios;

    [SerializeField] private Assistant assistant;


    private void Start()
    {
        if (menuPanel!= null)
        {
            menuPanel.SetActive(false);
        }
    }

    public void ShowHideMenu()
    {
        if (menuPanel != null)
        {
            menuPanel.SetActive(!menuPanel.activeInHierarchy);
        }
    }

    public void SetDialog()
    {
        if(text != null)
        {
            guiDialog.LoadDialogs(dialogs);
        }
        if(assistant != null)
        {
            if(audios.Length> 0)
            {
                assistant.LoadAudios(audios);
            }
        }
    }

    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
