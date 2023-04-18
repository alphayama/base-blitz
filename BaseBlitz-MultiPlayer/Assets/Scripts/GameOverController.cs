using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverController : MonoBehaviour
{
    float timeValue=6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(timeValue>0){
                timeValue-=Time.deltaTime;
            }
            else{
                timeValue=0 ;

                //go to game over scene
                SceneManager.LoadScene("StartMenu");
               // GameOver();
            }
    }

    public void LoadStartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
