using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneSpawner : MonoBehaviour
{
    [SerializeField] GameObject drone;
    [SerializeField] float timeBetweenTwoSpawns = 10;

    bool toSpawn;
    Vector3 spawnPosition;

    // Start is called before the first frame update
    void Start()
    {
        spawnPosition = new Vector3(transform.position.x, transform.position.y + 0.25f, transform.position.z);
        toSpawn = false;
        StartCoroutine(SpawnDroneTimer());

    }

    // Update is called once per frame
    void Update()
    {
        if (toSpawn)
        {
            SpawnDrone();
            StartCoroutine(SpawnDroneTimer());
        }
    }

    IEnumerator SpawnDroneTimer()
    {
        toSpawn = false;
        yield return new WaitForSeconds(timeBetweenTwoSpawns);
        toSpawn = true;
    }

    void SpawnDrone()
    {
        Instantiate(drone, spawnPosition, transform.rotation);
    }
}
