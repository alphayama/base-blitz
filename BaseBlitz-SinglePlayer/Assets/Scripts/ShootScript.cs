using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShootScript : MonoBehaviour
{
    RaycastHit hit;
    [SerializeField] AudioSource shootSound;
    public Camera playerCamera;
    public Transform laserOrigin;
    public float gunRange = 50f;
    public float fireRate = 0.2f;
    public float laserDuration = 0.05f;
    CollectibleCounter ammoCount;
    LineRenderer laserLine;
    float fireTimer = 0f;

    int healthReduction = 10;

    // Start is called before the first frame update
    void Start()
    {
        laserLine = GetComponent<LineRenderer>();
        ammoCount=GameObject.Find("AmmoButton").GetComponent<CollectibleCounter>();
        switch(PlayerPrefs.GetInt("difficulty", 0))
        {
            case 0: healthReduction = 10; break;
            case 1: healthReduction = 7; break;
            case 2: healthReduction = 5; break;
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Shoot()
    {
        shootSound.Play();

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit))
        {
            //Debug.Log("In shoot");
            if (hit.transform.tag == "MilitaryBaseItem")
            {
                //Debug.Log("In millitartBase");
                hit.transform.GetComponent<EnemyHealthScript>().ReduceHealth(healthReduction);

            }

            else if (hit.transform.parent.tag == "MilitaryBaseItem")
            {
                //Debug.Log("In millitartBase");
                hit.transform.parent.GetComponent<EnemyHealthScript>().ReduceHealth(healthReduction);

            }

            else if (hit.transform.parent.parent.tag == "MilitaryBaseItem")
            {
                //Debug.Log("In millitartBase");
                hit.transform.parent.parent.GetComponent<EnemyHealthScript>().ReduceHealth(healthReduction);

            }
        }

        DrawLaser();
        ammoCount.collectibleCount-=1;
    }

    public void DrawLaser()
    {
        //Debug.Log("In try Laser");
        fireTimer += Time.deltaTime;
        fireTimer = 0;
        //laserLine.SetPosition(0, laserOrigin.position);
        laserLine.SetPosition(0, new Vector3(0.3f, 0.3f, 0));
        //Vector3 rayOrigin = playerCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
        Vector3 rayOrigin = playerCamera.ViewportToWorldPoint(new Vector3(0f, 0f, 0));

        if (Physics.Raycast(rayOrigin, playerCamera.transform.forward, out hit))
        {
            laserLine.SetPosition(1, hit.point);
        }

        else
        {
            //laserLine.SetPosition(1, rayOrigin + (playerCamera.transform.forward * gunRange));
            laserLine.SetPosition(1, rayOrigin + (Camera.main.transform.forward * gunRange));
        }
        StartCoroutine(ShootLaser());
    }

    IEnumerator ShootLaser()
    {
        laserLine.enabled = true;
        yield return new WaitForSeconds(laserDuration);
        laserLine.enabled = false;
    }
}
