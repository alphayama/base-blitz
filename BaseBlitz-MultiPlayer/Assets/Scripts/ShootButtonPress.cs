using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ShootButtonPress : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    float threshold=2f;
    bool isPressed=false;
    public GameObject shootSystem;
    ShootScript shootScripts;
    RocketScript rocket;
    // Start is called before the first frame update
    void Start()
    {
        shootScripts=shootSystem.GetComponent<ShootScript>();
        rocket=GameObject.Find("RocketActive").GetComponent<RocketScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isPressed){
           // ShootScript.Shoot();
           shootScripts.Shoot();
           if(rocket.rocketActive==true){
                shootScripts.ShootRocket();
           }

        }   
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        isPressed = true;
    }

     public void OnPointerUp(PointerEventData eventData)
    {
        isPressed = false;
    }
    
    

}
    
