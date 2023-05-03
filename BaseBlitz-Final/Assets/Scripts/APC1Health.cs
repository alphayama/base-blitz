using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;


public class APC1Health : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] AudioSource destroySound;
    //[SerializeField] TextMeshProUGUI healthText;
    [SerializeField] Slider healthSlider;
    Transform playerTf; 
    [SerializeField] GameObject objHealthUI;
    RaycastHit hit;

    private List<GameObject> listOfChildren;

    // Start is called before the first frame update
    void Start()
    {
        destroySound = GameObject.FindGameObjectWithTag("DestroySound").GetComponent<AudioSource>();
        
         playerTf = GameObject.FindGameObjectWithTag("Player").transform;
       
        objHealthUI.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        // if (health <= 0)
        // {
        //     destroySound.Play();
        //     ProgressScript.UpdateProgress();
        //     Destroy(gameObject);
        // }

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit))
        {
           // Debug.Log("----------------------isPointing---------------------------");
           // Debug.Log("Hiiittttt----"+hit.transform.name);  
           // Debug.Log("oobbjjjj----"+gameObject.name);
        //    if (hit.transform.name == gameObject.name )
        //     {
        //     objHealthUI.transform.LookAt(playerTf);
        //     objHealthUI.SetActive(true);
        //     Debug.Log(objHealthUI);
        //     }
        //     else{
        //         objHealthUI.SetActive(false);
        //     }
                if (hit.transform.name == gameObject.name || hit.transform.name=="body"){  
                    Debug.Log("APC");
                    objHealthUI.SetActive(true);
                }
        }
    }

    public void ReduceHealth(int damage)
    {
        health -= damage;
        healthSlider.value=health;
        //healthText.transform.position = new Vector3(transform.position.x, transform.position.y + 0.2f, transform.position.z);
        //healthText.transform.LookAt(Camera.main.transform);
        //healthText.text = health.ToString();
        
    }
    public void DestroyEnemy()
    {
        health =0;
    }

}
