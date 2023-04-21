using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject playerPrefab;
    public float minX;
    public float minY;
    public float maxX;
    public float maxY;

    public void Start(){
        Vector3 randomPos = new Vector3(Random.Range(minX, maxX),Random.Range(minY, maxY));
        PhotonNetwork.Instantiate(playerPrefab.name, randomPos, Quaternion.identity);
    }
}
