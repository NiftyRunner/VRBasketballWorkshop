using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using TMPro;


public class timmer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float remainingtime;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (remainingtime > 0)
        {
            remainingtime -= Time.deltaTime;  
        }
        else if (remainingtime < 0)
        {
            remainingtime = 0;
        }
       
      
        int minutes = Mathf.FloorToInt(remainingtime / 60);
        int seconds = Mathf.FloorToInt(remainingtime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        
    }
}
