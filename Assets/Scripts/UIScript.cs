using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    public Button start;
    public Button settings;
    public Button instructions;
    public Button back;
    public Button backButton;
    public Button home;
    public GameObject menuPanel;
    public GameObject settingsPanel;
    public GameObject instructionsPanel;
    // Start is called before the first frame update
    void Start()
    {      
        start.onClick.AddListener(StartGame);
        settings.onClick.AddListener(Settings);
        home.onClick.AddListener(Home);
        back.onClick.AddListener(Back);
        backButton.onClick.AddListener(Back);
        instructions.onClick.AddListener(Instructions);
    }

    // Update is called once per frame
    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Settings()
    {
        settingsPanel.SetActive(true);
        menuPanel.SetActive(false);
        instructionsPanel.SetActive(false);
    }

    public void Home()
    {
        menuPanel.SetActive(true);
        settingsPanel.SetActive(false);
        instructionsPanel.SetActive(false);
    }
    public void Back()
    {
        menuPanel.SetActive(true);
        settingsPanel.SetActive(false);
        instructionsPanel.SetActive(false);
    }
    public void Instructions()
    {
        instructionsPanel.SetActive(true);
        settingsPanel.SetActive(false);
        menuPanel.SetActive(false);
       
    }
}
