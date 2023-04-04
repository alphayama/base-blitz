using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthBehaviour : MonoBehaviour
{
    [SerializeField] HealthBarSoreController healthScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            PlayerTakeDamage(20);
            Debug.Log(PlayerHealthManager.playerHealthManager.playerHealth.Health);
        }

        if(Input.GetKeyDown(KeyCode.Q)){
            PlayerTakeHeal(10);
            Debug.Log(PlayerHealthManager.playerHealthManager.playerHealth.Health);
        }
    }

    public void PlayerTakeDamage(int damage){
        PlayerHealthManager.playerHealthManager.playerHealth.DamageUnit(damage);
        healthScore.SetHealth(PlayerHealthManager.playerHealthManager.playerHealth.Health);
    }

    public void PlayerTakeHeal(int heal){
        PlayerHealthManager.playerHealthManager.playerHealth.HealHealth(heal);
        healthScore.SetHealth(PlayerHealthManager.playerHealthManager.playerHealth.Health);
    }
}
