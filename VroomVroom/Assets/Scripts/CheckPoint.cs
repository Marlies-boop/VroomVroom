using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class CheckPoint : MonoBehaviour
{
    public Vector3[] respawnPoint;
    public Vector3 currentRespawn;
    public int currentIndex = 0;
    public bool canFinish = true;

    [Header("Checkpoints")]
    public GameObject start;
    public GameObject end;
    public GameObject[] checkpoints;

    [Header("Laps")]
    public int totalLaps = 1;

    [Header("UI settings")]
    public Text lapText;
    public Text timeText;
    public Text checkpointText;
    public Timer timer;

    [Header("Information")]
    private int currentCheckpoint;
    private int currentLap;
    private bool started;
    private bool finished;

    private void Start()
    {
        currentRespawn = respawnPoint[currentIndex]; 
        currentCheckpoint = 0;
        currentLap = 1;
            

        started = false;
        finished = false;

       
    }

    private void Update()
    {
        if (currentCheckpoint == 1 && checkpoints[0].activeSelf == true)
        {
            checkpoints[0].SetActive(false);
        }
        else if (currentCheckpoint == checkpoints.Count() && checkpoints[0].activeSelf == false)
        {
            checkpoints[0].SetActive(true);
            currentIndex = 0;
        }
        
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
                canFinish = false;
                Debug.Log($"Can finish: {canFinish}");
            }
            else if (thisCheckpoint == end && started)
            {
                if (currentLap == totalLaps)
                {
                    finished = true;
                    Debug.Log("Finished");
                }
                else if (currentLap != totalLaps)
                {
                    if (canFinish == true && checkpoints[currentCheckpoint] == checkpoints[7])
                    Debug.Log("Current lap");
                    currentLap++;
                    currentCheckpoint = 0;
                    Debug.Log($"Started lap {currentLap}");
                }
                
            }

            bool correctCheckpoint = false;
            for (int i = 0; i < checkpoints.Length; i++)
            {
                if (finished)
                    return;

                if (thisCheckpoint == checkpoints[i] && i == currentCheckpoint)
                {
                    Debug.Log("Correct checkpoint");
                    currentCheckpoint++;
                    currentIndex++;
                   currentRespawn = respawnPoint[currentIndex];
                }
                else if (thisCheckpoint == checkpoints[i] && i != currentCheckpoint)
                {
                    checkpointText.text = "Wrong checkpoint";
                    checkpointText.gameObject.SetActive(true);
                }
            }
        }
    }
}