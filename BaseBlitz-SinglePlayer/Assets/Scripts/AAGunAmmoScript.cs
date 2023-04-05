using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAGunAmmoScript : MonoBehaviour
{
    Transform playerTf;
    Vector3 ammoMovemementDirection;
    float ammoDistanceMovedPerFrame;
    AudioSource hitPlayerSound;

    // Start is called before the first frame update
    void Start()
    {
        playerTf = GameObject.FindGameObjectWithTag("Player").transform;
        ammoDistanceMovedPerFrame = 50f * Time.deltaTime;
        hitPlayerSound = GameObject.FindGameObjectWithTag("HitPlayerSound").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        ammoMovemementDirection = playerTf.position - transform.position;
        
        if (ammoMovemementDirection.magnitude <= ammoDistanceMovedPerFrame)
        {
             hitPlayerSound.Play();
            //playerTf.GetComponent<HealthScript>.upda
        }

        else
        {
            transform.Translate(ammoMovemementDirection.normalized * ammoDistanceMovedPerFrame, Space.World);
        }
    }
}
