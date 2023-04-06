using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CounterText : MonoBehaviour
{
    public TMP_Text countText;
    public int ammoCount;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //speedButton.GetComponentInChildren<TMPro.TextMeshProUGUI>().text="Speed:High"
        countText.text= ammoCount.ToString();
    }
}
