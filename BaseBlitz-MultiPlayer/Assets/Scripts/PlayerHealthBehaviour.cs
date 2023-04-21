using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class PlayerHealthBehaviour : MonoBehaviour
{
    [SerializeField] HealthBarSoreController healthScore;
    public HealthBar playerHealth= new HealthBar(1000,1000);
    PhotonView view;
    // Start is called before the first frame update
    void Start()
    {
        view=GetComponent<PhotonView>();
    }

    // Update is called once per frame
    void Update()
    {
        if(view.IsMine){
        if (playerHealth.Health <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
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
