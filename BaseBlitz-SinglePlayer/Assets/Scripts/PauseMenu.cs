using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseMenuStart(){
        pauseMenu.SetActive(true);
        Time.timeScale=0f;
    }

    public void PauseMenuClose(){
        pauseMenu.SetActive(false);
        Time.timeScale=1f;
    }

    public void RestartGame(){
        pauseMenu.SetActive(false);
        Time.timeScale=1f;
        SceneManager.LoadScene("ARExample");
    }
}
