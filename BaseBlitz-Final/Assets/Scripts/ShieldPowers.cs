using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShieldPowers : MonoBehaviour
{
    public bool shieldActive;
    CollectibleCounter shield;
    public TextMeshProUGUI shieldActiveText;
    // Start is called before the first frame update
    void Start()
    {
        shield=GameObject.Find("ShieldButton").GetComponent<CollectibleCounter>();
        //shieldActiveText=GameObject.FindGameObjectWithTag("ShieldActiveText");
        shieldActiveText.enabled= false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetShieldActive(){
        if(shield.collectibleCount>0){
            shield.collectibleCount-=1;
            shieldActive=true;
            StartCoroutine(SetFalse());
            shieldActiveText.enabled=true;
        }
    }
    IEnumerator SetFalse(){
        yield return new WaitForSeconds(5); 
        shieldActive = false;
        shieldActiveText.enabled=false;
    }
}
