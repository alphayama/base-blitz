using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class CollectibleScript : MonoBehaviour {

	public enum CollectibleTypes {NoType, Shield, Health, Ammunition, Type4, Type5}; // you can replace this with your own labels for the types of collectibles in your game!
	public CollectibleTypes CollectibleType; // this gameObject's type
	public bool rotate; // do you want it to rotate?
	public float rotationSpeed;
	public AudioClip collectSound;

	public GameObject collectEffect;
	public float distanceThreshold = 0.1f; // The minimum distance at which the GameObject will be destroyed
    private GameObject arCamera;
	// Use this for initialization
	void Start () {
		arCamera= GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {

		if (rotate)
			transform.Rotate (Vector3.up * rotationSpeed * Time.deltaTime, Space.World);

		float distance = Vector3.Distance(transform.position, arCamera.transform.position);

        // If the distance is below the threshold, destroy the GameObject
        if (distance < distanceThreshold)
        {
			//Collect();
            Destroy(gameObject);
        }

	}

	// private void OnTriggerEnter(Collider other)
    // {
    //     // if (other.CompareTag("Player")) {
	// 	// 	//Destroy(gameObject);
	// 	// 	Collect();
	// 	// }
	// }

	public void Collect()
	{
		if(collectSound)
			AudioSource.PlayClipAtPoint(collectSound, transform.position);
		if(collectEffect)
			Instantiate(collectEffect, transform.position, Quaternion.identity);
		if (CollectibleType == CollectibleTypes.NoType) {
			Debug.Log ("Do NoType Command");
		}
		if (CollectibleType == CollectibleTypes.Shield) {

			Debug.Log ("Shield collected");
		}
		if (CollectibleType == CollectibleTypes.Health) {

			Debug.Log ("Health collected");
		}
		if (CollectibleType == CollectibleTypes.Ammunition) {
			Debug.Log ("Do NoType Command");
		}
		Destroy (gameObject);
	}
}
