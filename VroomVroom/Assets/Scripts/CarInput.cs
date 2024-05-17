using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;
using UnityEngine.InputSystem.DualShock;
using UnityEngine.InputSystem.XInput;
using UnityEngine.InputSystem.Controls;

public class CarInput : MonoBehaviour
{
    CarClass carInput;
    string inputType = "KBM"; // use this to know which control scheme is active
    public float driveValue;
    public float steerValue;
    public float lookValue;
    public bool brakeValue;
    public bool lightValue;
    int cameraType = 1;
    int gear = 1;
    int maxGear = 6;
    int minGear = 1;
    GameObject cam;

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
    // Start is called before the first frame update
    void Start()
    {
        cam = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {

        if (carInput.Car.Pause.WasPressedThisFrame())
        {
            // Pause the game
            Time.timeScale = 0f;
        }

        driveValue = carInput.Car.Drive.ReadValue<float>(); // sets value for driving
        print(carInput.Car.Drive.ReadValue<float>());
        //print(UserInput.instance.drive.ReadValue<float>());
        steerValue = carInput.Car.Steer.ReadValue<float>(); // sets value for steering
        lookValue = carInput.Car.Look.ReadValue<float>(); // sets values for right stick looking
        brakeValue = carInput.Car.Brake.IsPressed();
        lightValue = carInput.Car.Lights.WasReleasedThisFrame();
        var horLookValue = carInput.Car.LookH.ReadValue<float>(); // sets values for right stick looking
        var verLookValue = carInput.Car.RearView.ReadValue<float>(); // sets values for right stick looking
        //print(carInput.Car.Drive.GetBindingDisplayString());

        if (carInput.Car.Gears.WasPressedThisFrame())
        {
            gear += (int)carInput.Car.Gears.ReadValue<float>(); // Changes gear up or down
            gear = Mathf.Clamp(gear, minGear, maxGear); // Makes sure the gear doesnt go below or above the ranges
        }
        if (carInput.Car.ChangeCamera.WasPressedThisFrame())
        {
            cameraType += 1;
            if (cameraType >= 4)
            {
                cameraType = 1;
            }
            // change camera position here
        }
        //LookAround(); remove these slashes once looking has been updated to rotate the camera

        
    }
    
    void LookAround()
    {
        if (verLookValue < -0.75f)
        {
            cam.transform.rotation = Quaternion.Euler(cam.transform.rotation.x, 180, cam.transform.rotation.z);
        }
        else if(horLookValue > 0.1f || horLookValue < -0.1f)
        {
            cam.transform.rotation = Quaternion.Euler(cam.transform.rotation.x, horLookValue * 90, cam.transform.rotation.z); // change this rotation to apply on the camera
        }
        else
        {
            cam.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
