using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthManager : MonoBehaviour
{

    public static PlayerHealthManager playerHealthManager {get;private set;}
    public HealthBar playerHealth= new HealthBar(100,100);
    
    // Start is called before the first frame update
    
    void Awake(){
        if(playerHealthManager!=null && playerHealthManager !=this){
            Destroy(this);
        }
        else{
            playerHealthManager=this;
        }
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
