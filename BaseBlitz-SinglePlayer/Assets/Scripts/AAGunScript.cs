using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAGunScript : MonoBehaviour
{
    Transform playerTf;
    [SerializeField] GameObject ammo;
    [SerializeField] float ammoShootFrequencyInSeconds = 5;
    [SerializeField] float startAmmoShootCountdownInSeconds = 1;
    AudioSource aaGunShootSound;
    bool startShooting;

    // Start is called before the first frame update
    void Start()
    {
        playerTf = GameObject.FindGameObjectWithTag("Player").transform;
        aaGunShootSound = GameObject.FindGameObjectWithTag("AAGunShootSound").GetComponent<AudioSource>();
        startShooting = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(playerTf);
        if (startShooting)
            StartCoroutine(ShootAmmoAtRegularIntervals(ammoShootFrequencyInSeconds));
        else
            StartCoroutine(StartShootingAmmoCountdown(startAmmoShootCountdownInSeconds));
    }

    IEnumerator StartShootingAmmoCountdown(float ammoStartShootCountdown)
    {
        yield return new WaitForSeconds(ammoStartShootCountdown);
        startShooting = true;

    }

    IEnumerator ShootAmmoAtRegularIntervals(float timeInSeconds)
    {
        yield return new WaitForSeconds(timeInSeconds);
        ShootAmmo();
    }

    void ShootAmmo()
    {
        //aaGunShootSound.Play();
        Instantiate(ammo, transform.position, transform.rotation);
    }
}
