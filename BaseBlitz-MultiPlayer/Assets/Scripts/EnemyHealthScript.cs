using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealthScript : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] AudioSource destroySound;
    //[SerializeField] TextMeshProUGUI healthText;
    [SerializeField] Slider healthSlider;
    Transform playerTf; 
    [SerializeField] GameObject objHealthUI;
    RaycastHit hit;


    // Start is called before the first frame update
    void Start()
    {
        destroySound = GameObject.FindGameObjectWithTag("DestroySound").GetComponent<AudioSource>();
        //healthText = GameObject.FindGameObjectWithTag("HealthText").GetComponent<TextMeshProUGUI>();
         playerTf = GameObject.FindGameObjectWithTag("Player").transform;
        //healthText = GameObject.FindGameObjectWithTag("HealthText").GetComponent<TextMeshProUGUI>();
        objHealthUI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            destroySound.Play();
            ProgressScript.UpdateProgress();
            Destroy(gameObject);
        }

        // if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit))
        // {
        //    Debug.Log("----------------------isPointing---------------------------");
        //    Debug.Log("Hiiittttt----"+hit.transform.name);  
        //    Debug.Log("oobbjjjj----"+gameObject.name);
        //    if (hit.transform.name == gameObject.name )
        //     {
        //         objHealthUI.transform.LookAt(playerTf);
        //         objHealthUI.SetActive(true);
        //        Debug.Log(objHealthUI);
        //     }
        //     else if (hit.transform.tag == "MilitaryBaseItem")
        //     {
        //         Debug.Log("In millitartBase");
        //          objHealthUI.transform.LookAt(playerTf);
        //         objHealthUI.SetActive(true);
        //         StartCoroutine(ShowHealthBar());

        //     }

        //     else if (hit.transform.parent.tag == "MilitaryBaseItem")
        //     {
        //         Debug.Log("In millitartBase");
        //          objHealthUI.transform.LookAt(playerTf);
        //         objHealthUI.SetActive(true);
        //         StartCoroutine(ShowHealthBar());

        //     }

        //     else if (hit.transform.parent.parent.tag == "MilitaryBaseItem")
        //     {
        //         Debug.Log("In millitartBase");
        //         objHealthUI.transform.LookAt(playerTf);
        //         objHealthUI.SetActive(true);
        //         StartCoroutine(ShowHealthBar());

        //     }
        //     else{
        //         objHealthUI.SetActive(false);
        //     }
            
        // }
    }

    public void ReduceHealth(int damage)
    {
        //objHealthUI.SetActive(true);
        health -= damage;
        healthSlider.value=health;
       
        //healthText.transform.position = new Vector3(transform.position.x, transform.position.y + 0.2f, transform.position.z);
        //healthText.transform.LookAt(Camera.main.transform);
        //healthText.text = health.ToString();
        
    }
    public void CloseObjectHealth(){
        objHealthUI.SetActive(false);
    }

    public void DestroyEnemy()
    {
        health =0;
    }

    public void ShowHealthBarCaller()
    {
        objHealthUI.transform.LookAt(playerTf);
        StartCoroutine(ShowHealthBar());
    }

    IEnumerator ShowHealthBar()
    {
        objHealthUI.SetActive(true);
        yield return new WaitForSeconds(1.0f);
        objHealthUI.SetActive(false);
    }

}
