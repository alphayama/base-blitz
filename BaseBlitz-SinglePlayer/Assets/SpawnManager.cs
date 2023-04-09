using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabs;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RandomSpawnTimer());
    }

    void SpawnRandomObject()
    {
        Vector3 spawnPos = new Vector3(Random.Range(2.1f, -1.8f), Random.Range(0.5f, 0.8f), 1f); //Generate random object index and random spawn position

        int objectIndex = Random.Range(0, prefabs.Length); //Method scope to find array size and
        //prefabs[objectIndex].gameObject.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
        Instantiate(prefabs[objectIndex], spawnPos, prefabs[objectIndex].transform.rotation); //Instantiate prefabs at random location
    }

    IEnumerator RandomSpawnTimer()
    {
        while (true)
        {
            SpawnRandomObject();
            yield return new WaitForSeconds(Random.Range(5,30));

        }
    }

}