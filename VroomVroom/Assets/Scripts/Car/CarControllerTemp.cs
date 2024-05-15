using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(CarInput))]
public class CarControllerTemp : MonoBehaviour
{
    public CarInput inputmanager;
    public Rigidbody rb;
    public float Speed;
    public List<WheelCollider> throttlewheels;
    public List<GameObject> steeringwheels;
    public List<GameObject> meshes;
    public List<Light> lights;
    public WheelCollider WheelL, WheelR;
    public Vector3 CoM;
    public float strength = 20000f;
    public float maxturn = 20f;
    public float antiroll = 5000.0f;
    public float brakeTorque = 1000f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        inputmanager = GetComponent<CarInput>();
        rb.centerOfMass = CoM;
    }

    private void Update()
    {
        if (inputmanager.lightValue)
        {
            Headlights();
        }
    }

    void FixedUpdate()
    {
        Speed = rb.velocity.magnitude * 3.6f;
        print(Speed);
        foreach (WheelCollider wheel in throttlewheels)
        {
            wheel.motorTorque = strength * inputmanager.driveValue;
        }

        foreach (GameObject wheel in steeringwheels)
        {
            wheel.GetComponent<WheelCollider>().steerAngle = maxturn * inputmanager.steerValue;
            wheel.transform.localEulerAngles = new Vector3(0f, inputmanager.steerValue + maxturn, 0f);
        }
        foreach (GameObject mesh in meshes)
        {
            var parent = mesh.GetComponentInParent<WheelCollider>();
            UpdateWheelPos(parent, mesh.transform);
        }

        if (inputmanager.brakeValue == true)
        {
            foreach (WheelCollider wheel in throttlewheels)
            {
                wheel.brakeTorque = brakeTorque;
            }
        }
        else
        {
            foreach (WheelCollider wheel in throttlewheels)
            {
                wheel.brakeTorque = 0f;
            }
        }

        void UpdateWheelPos(WheelCollider collider, Transform transform)
        {
            Vector3 pos = transform.position;
            Quaternion quat = transform.rotation;

            collider.GetWorldPose(out pos, out quat);

            transform.position = pos;
            transform.rotation = quat;
        }

        WheelHit hit = new WheelHit();
        float travelL = 1.0f;
        float travelR = 1.0f;

        bool groundedL = WheelL.GetGroundHit(out hit);

        if (groundedL)
        {
            travelL = (-WheelL.transform.InverseTransformPoint(hit.point).y * WheelL.radius) / WheelL.suspensionDistance;
            
        }

        bool groundedR = WheelR.GetGroundHit(out hit);

        if (groundedR)
        {
            travelR = (-WheelR.transform.InverseTransformPoint(hit.point).y * WheelR.radius) / WheelR.suspensionDistance;

        }

        var antirollForce = (travelL - travelR) * antiroll;

        if (groundedL)
        {
            rb.AddForceAtPosition(WheelL.transform.up * -antirollForce, WheelL.transform.position);
        }
        if (groundedR)
        {
            rb.AddForceAtPosition(WheelR.transform.up * antirollForce, WheelR.transform.position);
        }
    }

    public void Headlights()
    {
        foreach (Light light in lights)
        {
            light.intensity = light.intensity == 0 ? 2 : 0 ;
        }
    }
}
