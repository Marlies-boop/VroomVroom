using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

public class CarInput : MonoBehaviour
{
    CarClass carInput;
    string inputType = "KBM";
    float driveValue;
    float steerValue;
    float lookValue;
    float timeNotLooking;
    int cameraType = 1;
    int gear = 1;
    int maxGear = 6;
    int minGear = 1;

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

    }

    // Update is called once per frame
    void Update()
    {
        CheckDeviceType();

        if (carInput.Car.Pause.WasPressedThisFrame())
        {
            // Pause the game
            Time.timeScale = 0f;
        }

        driveValue = carInput.Car.Drive.ReadValue<float>(); // sets value for driving
        steerValue = carInput.Car.Steer.ReadValue<float>(); // sets value for steering
        lookValue = carInput.Car.Look.ReadValue<float>(); // sets values for right stick looking

        if (carInput.Car.Gears.WasPressedThisFrame())
        {
            gear += (int)carInput.Car.Gears.ReadValue<float>(); // Changes gear up or down
            gear = Mathf.Clamp(gear, minGear, maxGear); // Makes sure the gear doesnt go below or above the range
            print(gear);
        }
        if (carInput.Car.ChangeCamera.WasPressedThisFrame())
        {
            cameraType += 1;
            if (cameraType >= 4)
            {
                cameraType = 1;
            }
            print(cameraType);
            // change camera position here
        }
        transform.Translate(0, 0, driveValue * Time.deltaTime * 6f); // feel free to change these to other movements like rigidbody.velocity if its better
        transform.Rotate(0, steerValue, 0); 
        //LookAround(); remove these slashes once looking has been updated to rotate the camera
       

        
    }
    void CheckDeviceType()
    {
        if (inputType != "KBM" && Input.anyKey || Input.GetMouseButtonDown(0))
        {
            inputType = "KBM";
            // refresh UI hints to show new keybinds
        }
        else if (Input.GetJoystickNames().Length > 0)
        {
            if (inputType != "PS" && Input.GetJoystickNames().Contains("PlayStation") || Input.GetJoystickNames().Contains("Sony"))
            {
                inputType = "PS";
                // refresh UI hints to show new keybinds
            }
            else if (inputType != "Xbox" && Input.GetJoystickNames().Contains("Xbox"))
            {
                inputType = "Xbox";
                // refresh UI hints to show new keybinds
            }
        }
        //else if (inputType != "Sim Rig" && Input.anyKey || Input.GetMouseButtonDown(0))
        //{
        //    inputType = "Sim Rig";
        //    // refresh UI hints to show new keybinds
        //}
    }
    void LookAround()
    {
        if(lookValue > 0.1f || lookValue < -0.1f)
        {
            transform.rotation = Quaternion.Euler(transform.rotation.x, lookValue * 90, transform.rotation.z); // change this rotation to apply on the camera
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        //else if (transform.rotation.y > 0.1f || transform.rotation.y < -0.1f && lookValue < 0.1f && lookValue > -0.1f && timeNotLooking < 1f)
        //{
        //    timeNotLooking += Time.deltaTime;

        //    if (timeNotLooking >= 1f)
        //    {
        //        transform.rotation = Quaternion.Euler(0, 0, 0);
        //        timeNotLooking = 0;
        //    }
        //}
    }
}
