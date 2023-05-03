using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SettingsScript : MonoBehaviour
{
    [SerializeField] GameObject mainMenuUI;
    [SerializeField] GameObject settingsUI;
    [SerializeField] GameObject helpUI;
    [SerializeField] TextMeshProUGUI difficultyButtonText;

    int difficultyLevel;

    // Start is called before the first frame update
    void Start()
    {
        difficultyLevel = PlayerPrefs.GetInt("difficulty", 0);
    }

    public void ShowSettings()
    {
        settingsUI.SetActive(true);
    }

    public void HideSettings()
    {
        settingsUI.SetActive(false);
    }

    public void toggleDifficulty()
    {
        switch (difficultyLevel)
        {
            case 0:
                difficultyLevel = 1;
                difficultyButtonText.text = "Medium";
                PlayerPrefs.SetInt("difficulty", 1);
                break;
            case 1:
                difficultyLevel = 2;
                difficultyButtonText.text = "Hard";
                PlayerPrefs.SetInt("difficulty", 2);
                break;
            case 2:
                difficultyLevel = 0;
                difficultyButtonText.text = "Easy";
                PlayerPrefs.SetInt("difficulty", 0);
                break;
        }
    }

    public void ShowHelp()
    {
        helpUI.SetActive(true);
    }

    public void HideHelp()
    {
        helpUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
