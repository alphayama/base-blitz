using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPowers : MonoBehaviour
{
    public bool shieldActive;
    CollectibleCounter shield;
    // Start is called before the first frame update
    void Start()
    {
        shield=GameObject.Find("ShieldButton").GetComponent<CollectibleCounter>();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetShieldActive(){
        shield.collectibleCount-=1;
        shieldActive=true;
        StartCoroutine(SetFalse());
    }
    IEnumerator SetFalse(){
        yield return new WaitForSeconds(5); 
        shieldActive = false;
    }
}
