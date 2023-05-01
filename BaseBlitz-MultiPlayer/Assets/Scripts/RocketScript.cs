using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class RocketScript : MonoBehaviour
{
    public TextMeshProUGUI rocketActiveText;
    public bool rocketActive;
    // Start is called before the first frame update
    void Start()
    {
        rocketActiveText.enabled= false;
        rocketActive=false;
    }

    public void SetRocketActive(){
        StartCoroutine(SetFalse());
        rocketActiveText.enabled=true;
        rocketActive=true;
        // shootRocket.ShootRocket();
    }
    IEnumerator SetFalse(){
        yield return new WaitForSeconds(5); 
        rocketActiveText.enabled=false;
        rocketActive=false;
    }
}
