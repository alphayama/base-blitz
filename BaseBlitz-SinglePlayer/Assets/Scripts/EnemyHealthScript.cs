using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyHealthScript : MonoBehaviour
{
    [SerializeField] int health;
    [SerializeField] AudioSource destroySound;
    [SerializeField] TextMeshProUGUI healthText;
    

    // Start is called before the first frame update
    void Start()
    {
        destroySound = GameObject.FindGameObjectWithTag("DestroySound").GetComponent<AudioSource>();
        //healthText = GameObject.FindGameObjectWithTag("HealthText").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            destroySound.Play();
            Destroy(gameObject);
        }
    }

    public void ReduceHealth(int damage)
    {
        health -= damage;
        healthText.transform.position = new Vector3(transform.position.x, transform.position.y + 0.2f, transform.position.z);
        healthText.transform.LookAt(Camera.main.transform);
        healthText.text = health.ToString();
        
    }

    

    //IEnumerator HealthDisplay()
    //{
    //    yield return new WaitForSeconds(1);
    //}
}
