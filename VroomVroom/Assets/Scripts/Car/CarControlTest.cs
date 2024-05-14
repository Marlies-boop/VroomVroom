using UnityEngine;

public class CarController : MonoBehaviour
{
    public WheelCollider[] driveWheelColliders;
    public WheelCollider[] steerWheelColliders;
    public Transform[] driveWheelTransforms;
    public Transform[] steerWheelTransforms;
    public float maxTorque = 500f;
    public float maxSteerAngle = 30f;
    public float brakeTorque = 1000f;
    public CarInput inputmanager;

    private void Update()
    {
        inputmanager = GetComponent<CarInput>();
    }

    private void FixedUpdate()
    {
        // Apply steering
        float steerAngle = maxSteerAngle * inputmanager.steerValue;
        foreach (WheelCollider wheel in steerWheelColliders)
        {
            wheel.steerAngle = steerAngle;
        }

        // Apply acceleration
        float torque = maxTorque * inputmanager.driveValue;
        foreach (WheelCollider wheel in driveWheelColliders)
        {
            wheel.motorTorque = torque;
        }

        // Apply braking
        if (Input.GetKeyDown("space"))
        {
            foreach (WheelCollider wheel in driveWheelColliders)
            {
                wheel.brakeTorque = brakeTorque;
            }
        }
        else
        {
            foreach (WheelCollider wheel in driveWheelColliders)
            {
                wheel.brakeTorque = 0f;
            }
        }

        // Update wheel positions and rotations
        UpdateWheelTransforms();
    }

    private void UpdateWheelTransforms()
    {
        // Update drive wheel transforms
        for (int i = 0; i < driveWheelColliders.Length; i++)
        {
            Quaternion rotation;
            Vector3 position;
            driveWheelColliders[i].GetWorldPose(out position, out rotation);
            driveWheelTransforms[i].rotation = rotation;
            driveWheelTransforms[i].position = position;
        }

        // Update steering wheel transforms and rotate them based on steer angle
        for (int i = 0; i < steerWheelColliders.Length; i++)
        {
            Quaternion rotation;
            Vector3 position;
            steerWheelColliders[i].GetWorldPose(out position, out rotation);
            steerWheelTransforms[i].rotation = rotation;
            steerWheelTransforms[i].Rotate(Vector3.up, maxSteerAngle * inputmanager.steerValue); // Rotate the steering wheel
            steerWheelTransforms[i].position = position;
        }
    }
}