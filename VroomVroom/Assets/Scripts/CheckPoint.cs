using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckPoint : MonoBehaviour
{
    [Header("Checkpoints")]
    public GameObject start;
    public GameObject end;
    public GameObject[] checkpoints;

    [Header("Laps")]
    public int totalLaps = 1;

    [Header("UI settings")]
    public Text lapText;
    public Text timeText;
    public Timer timer;

    [Header("Information")]
    private int currentCheckpoint;
    private int currentLap;
    private bool started;
    private bool finished;

    private void Start()
    {
        currentCheckpoint = 0;
        currentLap = 1;

        started = false;
        finished = false;
    }

    private void Update()
    {
        if (started && !finished)
        {
            lapText.text = "Lap: " + currentLap + "/" + totalLaps;
            timeText.text = timer.timeText.text;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Checkpoint"))
        {
            GameObject thisCheckpoint = other.gameObject;

            if (thisCheckpoint == start && !started)
            {
                Debug.Log("Started");
                started = true;
            }
            else if (thisCheckpoint == end && started)
            {
                if (currentLap == totalLaps)
                {
                    finished = true;
                    Debug.Log("Finished");
                }
                else
                {
                    currentLap++;
                    currentCheckpoint = 0;
                    Debug.Log($"Started lap {currentLap}");
                }
            }

            for (int i = 0; i < checkpoints.Length; i++)
            {
                if (finished)
                    return;

                if (thisCheckpoint == checkpoints[i] && i == currentCheckpoint)
                {
                    Debug.Log("Correct checkpoint");
                    currentCheckpoint++;
                }
                else if (thisCheckpoint == checkpoints[i] && i != currentCheckpoint)
                {
                    Debug.Log("Wrong checkpoint");
                }
            }
        }
    }
}