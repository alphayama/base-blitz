using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SettingsUIScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI difficultyButtonText;

    // Start is called before the first frame update
    void Start()
    {
        int difficultyLevel = PlayerPrefs.GetInt("difficulty", 0);
        switch (difficultyLevel)
        {
            case 0: difficultyButtonText.text = "Easy"; break;
            case 1: difficultyButtonText.text = "Medium"; break;
            case 2: difficultyButtonText.text = "Hard"; break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
