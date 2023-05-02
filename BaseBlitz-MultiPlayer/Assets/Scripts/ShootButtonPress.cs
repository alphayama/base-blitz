using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShootButtonPress : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    float threshold=2f;
    bool isPressed=false;
    public GameObject shootSystem;
    ShootScript shootScripts;
    RocketScript rocket;
    //ColorBlock buttonColor;
    // Start is called before the first frame update
    void Start()
    {
        shootScripts=shootSystem.GetComponent<ShootScript>();
        rocket=GameObject.Find("RocketActive").GetComponent<RocketScript>();
        //buttonColor = gameObject.GetComponent<Button>().colors;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPressed){
            gameObject.GetComponentInChildren<TextMeshProUGUI>().color = new Color(252, 201, 0);
            // ShootScript.Shoot();
            if (rocket.rocketActive==true){
                shootScripts.ShootRocket();
           }
           else{
                shootScripts.Shoot();
           }
        }   
        else
            gameObject.GetComponentInChildren<TextMeshProUGUI>().color = new Color(24, 24, 24);

    }
    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
        //gameObject.GetComponent<Image>().color = new Color(180, 0, 0);
    }

     public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
        //gameObject.GetComponent<Image>().color = new Color(24, 24, 24);
    }
    
    

}
    
