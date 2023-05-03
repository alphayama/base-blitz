using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAGunScript : MonoBehaviour
{
    Transform playerTf;
    [SerializeField] GameObject ammo;
    [SerializeField] float ammoShootFrequencyInSeconds = 5;
    //[SerializeField] float startAmmoShootCountdownInSeconds = 1;
    AudioSource aaGunShootSound;
    bool toShoot;

    // Start is called before the first frame update
    void Start()
    {
        playerTf = GameObject.FindGameObjectWithTag("Player").transform;
        aaGunShootSound = GameObject.FindGameObjectWithTag("AAGunShootSound").GetComponent<AudioSource>();
        toShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(playerTf);
        if (toShoot)
        {
            ShootAmmo();
            StartCoroutine(AAGunCooldown(ammoShootFrequencyInSeconds));
        }
    }

    //IEnumerator StartShootingAmmoCountdown(float ammoStartShootCountdown)
    //{
    //    yield return new WaitForSeconds(ammoStartShootCountdown);
    //    startShooting = true;

    //}

    IEnumerator AAGunCooldown(float timeInSeconds)
    {
        toShoot = false;
        yield return new WaitForSeconds(timeInSeconds);
        toShoot = true;
    }

    void ShootAmmo()
    {
        aaGunShootSound.Play();
        Instantiate(ammo, transform.position, transform.rotation);
    }
}
