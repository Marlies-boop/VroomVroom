using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(InputManTemp))]
public class CarControllerTemp : MonoBehaviour
{
    public InputManTemp inputmanager;
    public List<WheelCollider> throttlewheels;
    public List<WheelCollider> steeringwheels;
    public List<GameObject> meshes;
    public float strength = 20000f;
    public float maxturn = 20f;
    void Start()
    {
        inputmanager = GetComponent<InputManTemp>();
    }

    void FixedUpdate()
    {
        foreach (WheelCollider wheel in throttlewheels)
        {
            wheel.motorTorque = strength * Time.deltaTime * inputmanager.throttle;
        }

        foreach (WheelCollider wheel in steeringwheels)
        {
            wheel.steerAngle = maxturn * inputmanager.steering;
        }
    }
}
