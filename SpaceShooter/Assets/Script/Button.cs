using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    [SerializeField]
    private GameObject PlayMenu;
    [SerializeField]
    private GameObject SettingsMenu;
    
    // Start is called before the first frame update
    void Start()
    {
        SettingsMenu.SetActive(false);
        PlayMenu.SetActive(true);
    }

    public void StartClick()
    {
        SceneManager.LoadScene("Main");
    }

    public void SettingsMenuClick()
    {
        PlayMenu.SetActive(false);
        SettingsMenu.SetActive(true);
    }
    public void ExitClick()
    {
        Application.Quit();
    }
    public void Back()
    {
        SettingsMenu.SetActive(false);
        PlayMenu.SetActive(true);
    }
}
