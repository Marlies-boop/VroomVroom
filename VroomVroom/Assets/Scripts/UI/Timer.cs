using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private bool isRunning = true;

    private float seconds;
    private float minutes;
    private float hours;

    public TextMeshPro timeText;
    public float timeScale;

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

        timeText.text = finalizedTime + ":" + minutes + ":" + hours.ToString();
    }
}