using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AAGunScript : MonoBehaviour
{
    Transform playerTf;

    // Start is called before the first frame update
    void Start()
    {
        playerTf = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(playerTf);
    }
}
