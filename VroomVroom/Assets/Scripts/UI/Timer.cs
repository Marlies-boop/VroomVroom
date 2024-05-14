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

    public Text timeText;
    public float timeScale;

    private int lapsCompleted;
    public int totalLaps;

    void Update()
    {
        seconds += (Time.deltaTime * timeScale);

        float finalizedTime;
        finalizedTime = Mathf.Round(seconds);

        if (finalizedTime > 60)
        {
            minutes += 1f;
            seconds = seconds - 60f;
        }
        else if (minutes > 60)
        {
            hours += 1;
            minutes = minutes - 60f;
        }

        timeText.text = hours + ":" + minutes + ":" + finalizedTime.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("FinishLine"))
        {
            lapsCompleted++;

            if (lapsCompleted >= totalLaps)
            {
                isRunning = false;
            }
        }
    }
}