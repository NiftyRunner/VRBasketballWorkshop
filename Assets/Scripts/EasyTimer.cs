using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class EasyTimer : MonoBehaviour
{
    [Header("Timer UI References")]
    [SerializeField] private Image timerFillImage;
    [SerializeField] private TextMeshProUGUI timerText;

    [Header("Timer Settings")]
    public int totalTime = 60; 

    private int currentTime;

    private void Start()
    {
        InitializeTimerUI();
        //StartTimer(totalTime);
    }

    private void InitializeTimerUI()
    {
        currentTime = totalTime;
        timerFillImage.fillAmount = 1f;
        timerText.text = $"{totalTime / 60:D2}:{totalTime % 60:D2}";
    }

    public void StartTimer(int seconds)
    {
        currentTime = seconds;
        StartCoroutine(RunTimer());
    }

    private IEnumerator RunTimer()
    {
        while (currentTime > 0)
        {
            UpdateTimerUI(currentTime);
            currentTime--;
            yield return new WaitForSeconds(1f);
        }

        UpdateTimerUI(0);
    }

    private void UpdateTimerUI(int seconds)
    {
        timerFillImage.fillAmount = Mathf.InverseLerp(0, totalTime, seconds);
        timerText.text = $"{seconds / 60:D2}:{seconds % 60:D2}";
    }
}
