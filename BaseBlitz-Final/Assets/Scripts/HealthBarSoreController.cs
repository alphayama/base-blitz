using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarSoreController : MonoBehaviour
{
    [SerializeField] GameObject healthBarObj;
    Slider healthSlider;

    bool healthCheck1;
    bool healthCheck2;
    bool healthCheck3;
    // Start is called before the first frame update
    void Start()
    {
        healthBarObj=GameObject.FindGameObjectWithTag("HealthBar");
        healthSlider=healthBarObj.GetComponent<Slider>();
        healthCheck1 = true;
        healthCheck2 = true;
        healthCheck3 = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (healthSlider.value < 500 && healthCheck1)
        {
            Handheld.Vibrate();
            healthCheck1 = false;
        }

        if (healthSlider.value < 200 && healthCheck2)
        {
            Handheld.Vibrate();
            healthCheck2 = false;
        }

        if (healthSlider.value < 50 && healthCheck3)
        {
            Handheld.Vibrate();
            healthCheck3 = false;
        }
    }

   

    public void SetMaxHealth(int maxHealth){
        healthSlider.maxValue=maxHealth;
        healthSlider.value=maxHealth;
    }

    public void SetHealth(int health){
        
        healthSlider.value=health;
    }
}
