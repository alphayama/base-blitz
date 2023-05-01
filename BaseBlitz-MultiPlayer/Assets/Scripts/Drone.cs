using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Drone : MonoBehaviour
{
    Transform playerTf;
    NavMeshAgent nMagent;
    [SerializeField] GameObject droneAmmo;
    [SerializeField] float ammoShootFrequencyInSeconds = 5;

    bool toShoot;

    LayerMask ifGround;
    LayerMask ifPlayer;

    Vector3 newMoveLocation;
    float minMaxXZ = 8f;
    float minY = 0.7f;
    float maxY = 6.0f;

    [SerializeField] float attackInterval = 5;

    // Start is called before the first frame update
    void Start()
    {
        playerTf = GameObject.FindGameObjectWithTag("Player").transform;
        nMagent = GetComponent<NavMeshAgent>();
        toShoot = true;
    }

    // Update is called once per frame
    void Update()
    {
        ChaseAndAttack();
    }

    void ChaseAndAttack()
    {
        //float xCoordinate = Random.Range(-minMaxXZ, minMaxXZ);
        //float yCoordinate = Random.Range(-minY, minY);
        //float zCoordinate = Random.Range(-minMaxXZ, minMaxXZ);

        //newMoveLocation = new Vector3(xCoordinate, yCoordinate, zCoordinate);
        nMagent.SetDestination(playerTf.position);
        transform.LookAt(playerTf);

        if (toShoot)
        {
            ShootAmmo();
            StartCoroutine(DroneCooldown(ammoShootFrequencyInSeconds));
        }
    }

    IEnumerator DroneCooldown(float timeInSeconds)
    {
        toShoot = false;
        yield return new WaitForSeconds(timeInSeconds);
        toShoot = true;
    }

    void ShootAmmo()
    {
        Instantiate(droneAmmo, transform.position, transform.rotation);
    }
}
