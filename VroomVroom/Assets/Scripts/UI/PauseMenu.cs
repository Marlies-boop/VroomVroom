using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public CheckPoint checkpoint;
    CarClass carInput;
    public static bool Paused = false;
    public GameObject PauseMenuCanvas;
    public Transform player;
    
    private void Awake()
    {
        carInput = new CarClass();
    }
    private void OnEnable()
    {
        carInput.Enable();
    }
    private void OnDisable()
    {
        carInput.Disable();
    }
    void Start()
    {
        //checkpoint = GetComponent<CheckPoint>();
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (carInput.Car.Pause.WasReleasedThisFrame())
        {
            Debug.Log("Knop ingedrukt");
            if (Paused)
            {
                Play();
            }
            else
            {
                Stop();
            }
        }
    }
    void Stop()
    {
        Debug.Log("Pauze");
        PauseMenuCanvas.SetActive(true);
        Time.timeScale = 0f;
        Paused = true;
    }

    public void Play()
    {
        PauseMenuCanvas.SetActive(false);
        Time.timeScale = 1f;
        Paused = false;
    }

    public void MainMenuButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void Respawn()
    {
        //GameObject player = GameObject.FindGameObjectWithTag("Player");
        Debug.Log($"player position = {player.position}");
        //Debug.Log($"current chekcpoint position = {checkpoint.currentRespawn.position}");
        
       player.position = checkpoint.currentRespawn;

        //player.transform.rotation = respawnPoint.rotation;

        Play();
    }
}