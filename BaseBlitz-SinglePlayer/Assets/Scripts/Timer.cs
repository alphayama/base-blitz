using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeValue =90;
    public TMP_Text timeText;
    
    public GameObject militaryBase;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        //if(militaryBase.activeSelf==true){ 
            if(timeValue>0){
                timeValue-=Time.deltaTime;
            }
            else{
                timeValue=0 ;

                //go to game over scene
                SceneManager.LoadScene("GameOver");
               // GameOver();
            }
            DisplayTime(timeValue);
        //}
    }

    void DisplayTime(float toDisplay)
    {
        if(toDisplay<0)
        {
            toDisplay=0;
        }

        float minutes=Mathf.FloorToInt(toDisplay/60);
        float seconds =Mathf.FloorToInt(toDisplay%60);

        timeText.text=string.Format("{0:00} : {1:00}",minutes,seconds);
    }

    
}
