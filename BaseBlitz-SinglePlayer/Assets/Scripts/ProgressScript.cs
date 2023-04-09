using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ProgressScript : MonoBehaviour
{
    static int numOfEnemyUnitsDestroyed;
    
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
        if (numOfEnemyUnitsDestroyed > 25) 
        {
            SceneManager.LoadScene("GameWon");
        }
    }
}
