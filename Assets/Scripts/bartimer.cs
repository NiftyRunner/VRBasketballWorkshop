using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using UnityEngine.UI;


public class bartimer : MonoBehaviour
{
    public Slider timerSlider;
    public float sliderTimer;
    public bool stopTimer = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timerSlider.maxValue = sliderTimer;
        timerSlider.value = sliderTimer;
        StartTimer();


    }
    public void StartTimer()
    {
        StartCoroutine(StartTheTimerTicker());

    }
    IEnumerator StartTheTimerTicker()
    {
        while (stopTimer == false)
        {
            sliderTimer -= Time.deltaTime;

            yield return new WaitForSeconds(0.001f);
            if (sliderTimer <= 0)
            {
                stopTimer = true;
            }
            if (stopTimer == false)
            {
                timerSlider.value = sliderTimer;
            }
        }

        // Update is called once per frame
        
    }
    public void StopTimer()
    {
        stopTimer = true;

    }
}