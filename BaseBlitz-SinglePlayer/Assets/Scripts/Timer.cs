using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeValue = 90;
    
     TMP_Text timeText;
    GameObject timeTextObj;
  // public GameObject militaryBase;
    // Start is called before the first frame update
    void Start()
    {
        
        timeTextObj = GameObject.FindGameObjectWithTag("TimerText");
        Debug.Log("#############################Hellooooooooooooooooooooooooooo#########################################");
        Debug.Log("------------------------------"+timeTextObj);
        timeText = timeTextObj.GetComponent<TMP_Text>();
        timeValue = 90;
        
       //timeText.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {  
        
       //Debug.Log(militaryBase.activeInHierarchy);
       
        //if(militaryBase.activeSelf==true){ 
           // timeValue = 90;
            if(timeValue>0){
                timeValue-=Time.deltaTime;
            }
            else{
                timeValue=0 ;

                //go to game over scene
                SceneManager.LoadScene("GameOver");
               // GameOver();
            }
            DisplayTimer(timeValue);
       // }
    }

   public void DisplayTimer(float toDisplay)
    { 
        Debug.Log("@@@@@@@@@@@@@@@@@@@@@@@@@@@@---------- in Display"+timeText.text);
        if(toDisplay<0)
        {
            toDisplay=0;
        }

        float minutes=Mathf.FloorToInt(toDisplay/60);
        float seconds =Mathf.FloorToInt(toDisplay%60);
        
        timeText.text=string.Format("{0:00} : {1:00}",minutes,seconds);
    }

    
}
