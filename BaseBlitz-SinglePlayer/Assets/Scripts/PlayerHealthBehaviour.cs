using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthBehaviour : MonoBehaviour
{
    [SerializeField] HealthBarSoreController healthScore;
    public HealthBar playerHealth= new HealthBar(1000,1000);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerHealth.Health <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    public void PlayerTakeDamage(int damage){
        //PlayerHealthManager.playerHealthManager.playerHealth.DamageUnit(damage);
        playerHealth.DamageUnit(damage);
        healthScore.SetHealth(playerHealth.Health);
    }

    public void PlayerTakeHeal(int heal){
       // PlayerHealthManager.playerHealthManager.playerHealth.HealHealth(heal);
        playerHealth.HealHealth(heal);
        healthScore.SetHealth(playerHealth.Health);
    }
}
