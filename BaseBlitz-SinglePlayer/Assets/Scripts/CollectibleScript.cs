﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(AudioSource))]
public class CollectibleScript : MonoBehaviour {

	public enum CollectibleTypes {Shield, Health, Ammunition}; 
	public CollectibleTypes CollectibleType; 
	public bool rotate; 
	public float rotationSpeed;
	public AudioClip collectSound;
	public GameObject collectEffect;
	public float distanceThreshold = 0.3f; 
    private GameObject arCamera;
	CollectibleCounter ammo;
	CollectibleCounter shield;
	
	void Start () {
		arCamera= GameObject.FindGameObjectWithTag("Player");	
		ammo=GameObject.Find("Ammo").GetComponent<CollectibleCounter>();
		shield=GameObject.Find("Shield").GetComponent<CollectibleCounter>();
	}
	
	// Update is called once per frame
	void Update () {

		if (rotate)
			transform.Rotate (Vector3.up * rotationSpeed * Time.deltaTime, Space.World);

		float distance = Vector3.Distance(transform.position, arCamera.transform.position);

        if (distance < distanceThreshold)
        {
			Collect();
        }

	}

	public void Collect()
	{
		if(collectSound)
			AudioSource.PlayClipAtPoint(collectSound, transform.position);
		if(collectEffect)
			Instantiate(collectEffect, transform.position, Quaternion.identity);
		if (CollectibleType == CollectibleTypes.Shield) {
			shield.collectibleCount+=1;
		}
		if (CollectibleType == CollectibleTypes.Health) {

			Debug.Log ("Health collected");
		}
		if (CollectibleType == CollectibleTypes.Ammunition) {
			ammo.collectibleCount+=1;
		}
		Destroy(gameObject);
	}
}
