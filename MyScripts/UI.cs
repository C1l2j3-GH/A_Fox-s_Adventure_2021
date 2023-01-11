using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using TMPro;
public class UI : MonoBehaviour
{
    public Button startButton;
    public Button settingsButton;
    public Button quitButton;
    public Button backButton;

    public GameObject mainMenuPanel;
    public GameObject settingsPanel;

    public TMP_Text menuText;

    public AudioMixer myMixer;

    public Slider volSlider;

    //public float currentVolume;

    public Toggle mute_Toggle;

    public AudioSource myAudioSource;

    public void startGame()
    {
        SceneManager.LoadScene(0);
        mainMenuPanel.SetActive(true);
        settingsPanel.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        //startButton.onClick.AddListener(startGameScene);
        settingsButton.onClick.AddListener(settingsMenu);
        backButton.onClick.AddListener(backToMain);
        quitButton.onClick.AddListener(quitGame);
        
    }
    private void settingsMenu()
    {
        mainMenuPanel.SetActive(false);
        settingsPanel.SetActive(true);
        //menuText.text = "Settings";
    }

    public void backToMain()
    {
        mainMenuPanel.SetActive(true);
        settingsPanel.SetActive(false);
        //menuText.text = "A Fox’s Adventure";
    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void myVolume(float sliderValue)
    {
        myMixer.SetFloat("Volume", sliderValue);
        //myMixer.SetFloat("Volume", Mathf.Log10(sliderValue) * 20);
    }
   
    public void startGameScene()
    {
        SceneManager.LoadScene(2);
    }

    public void toggleMute()
    {
        myAudioSource.mute = !myAudioSource.mute;
    }

}
