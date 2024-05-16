using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private bool isRunning = true;

    private float seconds;
    private float minutes;
    private float hours;

    [Header("UI References")]
    public Text timeText;
    public Text lapsText;

    private int lapsCompleted;
    public int totalLaps;

    [Header("Time Settings")]
    public float timeScale = 1.0f;

    public void StartTimer()
    {
        isRunning = true;
    }

    public void StopTimer()
    {
        isRunning = false;
    }

    public string GetFormattedTime()
    {
        return string.Format("{0:00}:{1:00}:{2:00}", hours, minutes, Mathf.RoundToInt(seconds));
    }

    void Update()
    {
        if (isRunning)
        {
            float deltaTime = Time.deltaTime * timeScale;

            seconds += deltaTime;

            if (seconds >= 60)
            {
                minutes++;
                seconds -= 60;
            }

            if (minutes >= 60)
            {
                hours++;
                minutes -= 60;
            }

            UpdateUIText();
        }
    }

    void UpdateUIText()
    {
        timeText.text = GetFormattedTime();
        lapsText.text = "Laps: " + lapsCompleted + "/" + totalLaps;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FinishLine"))
        {
            lapsCompleted++;

            if (lapsCompleted >= totalLaps)
            {
                StopTimer();
            }
        }
    }
}