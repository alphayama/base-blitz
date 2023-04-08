using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class rayCast : MonoBehaviour
{
    public Camera playerCamera;
    public Transform laserOrigin;
    public float gunRange = 50f;
    public float fireRate = 0.2f;
    public float laserDuration = 0.05f;

    LineRenderer laserLine;
<<<<<<< HEAD
<<<<<<< HEAD
    bool isRun = false;
    float fireTimer;
=======
    float fireTimer;
    bool isRun = false;
>>>>>>> 50e5634 (Try Laser)
=======
    bool isRun = false;
    float fireTimer;
>>>>>>> bcedc49 (Laser Done)

    void Awake()
    {
        laserLine = GetComponent<LineRenderer>();
    }

    void Update()
    {
<<<<<<< HEAD
<<<<<<< HEAD
        Debug.Log("******************In rayCast ************");
        fireTimer += Time.deltaTime;
        if (isRun) { 
=======
        if (isRun)
        {
            Debug.Log("******************In rayCast ************");
            fireTimer += Time.deltaTime;
>>>>>>> 50e5634 (Try Laser)
=======
        Debug.Log("******************In rayCast ************");
        fireTimer += Time.deltaTime;
        if (isRun) { 
>>>>>>> bcedc49 (Laser Done)
            fireTimer = 0;
            laserLine.SetPosition(0, laserOrigin.position);
            Vector3 rayOrigin = playerCamera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;
<<<<<<< HEAD
<<<<<<< HEAD
=======

>>>>>>> 50e5634 (Try Laser)
=======
>>>>>>> bcedc49 (Laser Done)
            if (Physics.Raycast(rayOrigin, playerCamera.transform.forward, out hit, gunRange))
            {
                laserLine.SetPosition(1, hit.point);
                Destroy(hit.transform.gameObject);
            }
<<<<<<< HEAD
<<<<<<< HEAD
=======

>>>>>>> 50e5634 (Try Laser)
=======
>>>>>>> bcedc49 (Laser Done)
            else
            {
                laserLine.SetPosition(1, rayOrigin + (playerCamera.transform.forward * gunRange));
            }
            StartCoroutine(ShootLaser());
        }
    }

    IEnumerator ShootLaser()
    {
        laserLine.enabled = true;
        yield return new WaitForSeconds(laserDuration);
        laserLine.enabled = false;
    }
}