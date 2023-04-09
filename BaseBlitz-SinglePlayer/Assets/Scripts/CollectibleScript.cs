using System.Collections;
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
	public float distanceThreshold = 0.8f; 
    private GameObject arCamera;
	CollectibleCounter ammo;
	CollectibleCounter shield;
	Transform playerTf;
	int playerHealthAdd = 500;

	void Start () {
		arCamera= GameObject.FindGameObjectWithTag("Player");	
		ammo=GameObject.Find("AmmoButton").GetComponent<CollectibleCounter>();
		shield=GameObject.Find("ShieldButton").GetComponent<CollectibleCounter>();
		playerTf = GameObject.FindGameObjectWithTag("Player").transform;
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
			playerTf.GetComponent<PlayerHealthBehaviour>().PlayerTakeHeal(playerHealthAdd);
			Debug.Log ("Health collected");
		}
		if (CollectibleType == CollectibleTypes.Ammunition) {
			ammo.collectibleCount+=1;
		}
		Destroy(gameObject);
	}
}
