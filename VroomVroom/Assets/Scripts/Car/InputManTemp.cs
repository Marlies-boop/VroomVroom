using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManTemp : MonoBehaviour
{
    public float throttle;
    public float steering;
    // Update is called once per frame
    void Update()
    {
        throttle = Input.GetAxis("Vertical");
        steering = Input.GetAxis("Horizontal");
    }
}
