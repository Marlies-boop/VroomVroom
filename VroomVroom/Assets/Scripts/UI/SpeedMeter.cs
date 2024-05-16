using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpeedMeter : MonoBehaviour
{
    public Text textSpeed;
    public Rigidbody playerRigidbody;
    public int maxSpeed = 200;

    void Start()
    {
        if (playerRigidbody == null)
        {
            playerRigidbody = GetComponent<Rigidbody>();
        }
    }

    void Update()
    {
        float speedKMH = playerRigidbody.velocity.magnitude * 3.6f;

        speedKMH = Mathf.Clamp(speedKMH, 0f, maxSpeed);

        textSpeed.text = "KM/H: " + speedKMH.ToString("F0");
    }
}