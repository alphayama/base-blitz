using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ShootScript : MonoBehaviour
{
    RaycastHit hit;
    [SerializeField] AudioSource shootSound;

    // Start is called before the first frame update
    void Start()
    {
        
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
            if (hit.transform.tag == "MilitaryBaseItem")
            {
                hit.transform.GetComponent<EnemyHealthScript>().ReduceHealth(10);
            }
        }
    }
}
