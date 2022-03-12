using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using Slider = UnityEngine.UI.Slider;
using TMPro;

public class ButtonLobby : MonoBehaviour
{
    [SerializeField] private GameObject PlayMenu;
    [SerializeField] private GameObject SettingsMenu;
    [SerializeField] private GameObject mainText;
    [SerializeField] private GameObject scoreText;
    [SerializeField] private GameObject loginScene;
    
    [SerializeField] private Slider fpsSlider;
    [SerializeField] private Slider masterVolumeSlider;
    [SerializeField] private Slider vfxSlider;
    [SerializeField] private Slider musicVolumeSlider;
    
    
    [SerializeField] private TextMeshProUGUI fpsTxt;
    [SerializeField] private TextMeshProUGUI masterVolumeTxt;
    [SerializeField] private TextMeshProUGUI vfxVolumeTxt;
    [SerializeField] private TextMeshProUGUI musicVolumeTxt;

    [SerializeField] private TextMeshProUGUI loggedAsTxt;

    [SerializeField] private AudioMixer audioMixer;
    
    [SerializeField] private TMP_InputField InputField;
    
    public DataManager DataManager;
    public SaveData SaveData;
    
    public ScoreData ScoreData;
    
    // Start is called before the first frame update
    void Start()
    {
        DataManager.LoadData();
        
        fpsSlider.value = SaveData.fpsInt;
        masterVolumeSlider.value = SaveData.masterVolume;
        vfxSlider.value = SaveData.vfxvolume;
        musicVolumeSlider.value = SaveData.musicVolume;
        
        SettingsMenu.SetActive(false);
        PlayMenu.SetActive(false);
        mainText.SetActive(false);
        scoreText.SetActive(false);
        loginScene.SetActive(true);
    }

    private void Update()
    {
        SaveData.fpsInt = Convert.ToInt32(fpsSlider.value);

        SaveData.masterVolume = masterVolumeSlider.value;
        SaveData.vfxvolume = vfxSlider.value;
        SaveData.musicVolume = musicVolumeSlider.value;
        
        
        fpsTxt.text = $"{SaveData.fpsInt}";
        masterVolumeTxt.text = $"{Mathf.Log10(SaveData.masterVolume) * 20} DB";
        vfxVolumeTxt.text = $"{Mathf.Log10(SaveData.vfxvolume)*20} DB";
        musicVolumeTxt.text = $"{Mathf.Log10(SaveData.musicVolume)*20} DB";

        audioMixer.SetFloat("masterVolumeMixer", Mathf.Log10(SaveData.masterVolume) * 20);
        audioMixer.SetFloat("musicVolumeMixer", Mathf.Log10(SaveData.musicVolume)*20);
        audioMixer.SetFloat("vfxVolumeMixer", Mathf.Log10(SaveData.vfxvolume)*20);
    }

    public void StartClick()
    {
        SceneManager.LoadScene("Main");
    }

    public void SettingsMenuClick()
    {
        PlayMenu.SetActive(false);
        mainText.SetActive(false);
        scoreText.SetActive(false);
        SettingsMenu.SetActive(true);
    }
    public void ExitClick()
    {
        Application.Quit();
    }
    public void Back()
    {
        DataManager.SaveData();
        SettingsMenu.SetActive(false);
        mainText.SetActive(true);
        PlayMenu.SetActive(true);
        scoreText.SetActive(true);
    }

    public void LoginClick()
    {
        ScoreData.lastName = InputField.text;
        loggedAsTxt.text = $"Logged as: {ScoreData.lastName}";
        loginScene.SetActive(false);
        PlayMenu.SetActive(true);
        mainText.SetActive(true);
        scoreText.SetActive(true);
    }
}
