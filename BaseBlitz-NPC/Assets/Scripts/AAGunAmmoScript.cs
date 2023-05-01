using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAGunAmmoScript : MonoBehaviour
{
    Transform playerTf;
    Vector3 ammoMovemementDirection;
    float ammoDistanceMovedPerFrame;
    AudioSource hitPlayerSound;
    float ammoSpeed = 1f;
    int playerDamage = 10;
    ShieldPowers shield;


    // Start is called before the first frame update
    void Start()
    {
        playerTf = GameObject.FindGameObjectWithTag("Player").transform;
        ammoDistanceMovedPerFrame = ammoSpeed * Time.deltaTime;
        hitPlayerSound = GameObject.FindGameObjectWithTag("HitPlayerSound").GetComponent<AudioSource>();
        shield=GameObject.Find("ShieldButton").GetComponent<ShieldPowers>();
        switch (PlayerPrefs.GetInt("difficulty", 0))
        {
            case 0: playerDamage = 10; break;
            case 1: playerDamage = 20; break;
            case 2: playerDamage = 30; break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        ammoMovemementDirection = playerTf.position - transform.position;
        
        // Checks if the ammunition is in the vicinity of the player
        if (ammoMovemementDirection.magnitude <= ammoDistanceMovedPerFrame)
        {
            if(shield.shieldActive==false){
                hitPlayerSound.Play();
                Handheld.Vibrate();
                playerTf.GetComponent<PlayerHealthBehaviour>().PlayerTakeDamage(playerDamage);
            }
            Destroy(gameObject);
        }

        else
        {
            transform.Translate(ammoMovemementDirection.normalized * ammoDistanceMovedPerFrame, Space.World);
        }
    }

    // Automatically destroy the AA Gun shell after 15 seconds.
    IEnumerator AutoDestroyAmmo()
    {
        yield return new WaitForSeconds(15);
        Destroy(gameObject);
    }
}
