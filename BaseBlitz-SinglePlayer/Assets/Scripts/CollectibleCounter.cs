using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CollectibleCounter : MonoBehaviour
{
    public int collectibleCount;
    //public int shieldCount;
    public TextMeshProUGUI collectibleText;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        collectibleText.text= collectibleCount.ToString();
        //shieldtext.text= shieldCount.ToString();
    }
}
