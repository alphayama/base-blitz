using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ProgressScript : MonoBehaviour
{
    static int numOfEnemyUnitsDestroyed;
    [SerializeField] Slider progressSlider;
    
    // Start is called before the first frame update
    void Start()
    {
        numOfEnemyUnitsDestroyed = 0;
    }

    public static void UpdateProgress()
    {
        numOfEnemyUnitsDestroyed++;
        
    }

    // Update is called once per frame
    void Update()
    {
        progressSlider.value = numOfEnemyUnitsDestroyed;
        if (numOfEnemyUnitsDestroyed > 25) 
        {
            SceneManager.LoadScene("GameWon");
        }
    }
}
