using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Users;

public class CarInput : MonoBehaviour
{
    CarClass carInput;
    string inputType = "KBM"; // use this to know which control scheme is active
    float driveValue;
    float steerValue;
    float horLookValue;
    float verLookValue;
    int cameraType = 1;
    int gear = 1;
    int maxGear = 6;
    int minGear = 1;
    GameObject camera;

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
        camera = GameObject.Find("Main Camera");
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
        horLookValue = carInput.Car.LookH.ReadValue<float>(); // sets values for right stick looking
        verLookValue = carInput.Car.LookV.ReadValue<float>(); // sets values for right stick looking

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
        LookAround(); 
       

        
    }
    void CheckDeviceType()
    {
        if (inputType != "KBM" && Input.anyKey || Input.GetMouseButtonDown(0))
        {
            inputType = "KBM";
            // refresh UI hints to show new keybinds
        }
        else if (Gamepad.current != null && Gamepad.current.name.Contains("Xbox"))
        {
            inputType = "Xbox";
            //if (inputType != "PS" && Input.GetJoystickNames().Contains("PlayStation") || Input.GetJoystickNames().Contains("Sony"))
            //{
            //    inputType = "PS";
            //    // refresh UI hints to show new keybinds
            //}
            //else if (inputType != "Xbox" && Input.GetJoystickNames().Contains("Xbox"))
            //{
            //    inputType = "Xbox";
            //    // refresh UI hints to show new keybinds
            //}
        }
        else if (Gamepad.current != null && Gamepad.current.name.Contains("Sony") || Gamepad.current != null && Gamepad.current.name.Contains("PlayStation"))
        {
            inputType = "PS";
        }
        //else if (inputType != "Sim Rig" && Input.anyKey || Input.GetMouseButtonDown(0))
        //{
        //    inputType = "Sim Rig";
        //    // refresh UI hints to show new keybinds
        //}
        print(inputType);
    }
    void LookAround()
    {
        if (verLookValue < -0.75f)
        {
            camera.transform.rotation = Quaternion.Euler(camera.transform.rotation.x, 180, camera.transform.rotation.z);
        }
        else if(horLookValue > 0.1f || horLookValue < -0.1f)
        {
            camera.transform.rotation = Quaternion.Euler(camera.transform.rotation.x, horLookValue * 90, camera.transform.rotation.z); // change this rotation to apply on the camera
        }
        else
        {
            camera.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
