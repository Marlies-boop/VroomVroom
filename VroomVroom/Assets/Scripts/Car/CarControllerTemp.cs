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

        foreach (GameObject wheel in steeringwheels)
        {
            wheel.GetComponent<WheelCollider>steerAngle = maxturn * inputmanager.steering;
            wheel.transform.localEulerAngles = new Vector3(0f, inputmanager.steering + maxturn, 0f);
        }
    }
}
