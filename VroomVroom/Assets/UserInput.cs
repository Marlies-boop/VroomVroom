using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class UserInput : MonoBehaviour
{
    public static UserInput instance;

    private InputAction _driveAction;
    private InputAction _steerAction;
    private InputAction _lookHAction;
    private InputAction _rearViewAction;
    private InputAction _lightsAction;
    private InputAction _gearsAction;
    private InputAction _pauseAction;
    private InputAction _changeCameraAction;
    private InputAction _handbrakeAction;

    public PlayerInput _playerInput;

    public InputAction drive;
    public InputAction steer;
    public InputAction lookH;
    public InputAction rearView;
    public InputAction lights;
    public InputAction gears;
    public InputAction pause;
    public InputAction changeCamera;
    public InputAction handbrake;

    // Start is called before the first frame update
    void Start()
    {
        if (instance == null)
        {
            instance = this;
        }
        _playerInput = GameObject.Find("Cube").GetComponent<PlayerInput>();

        SetupInputActions();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateInputs();
    }
    private void SetupInputActions()
    {
        _driveAction = _playerInput.actions["Drive"];
        _steerAction = _playerInput.actions["Steer"];
        _lookHAction = _playerInput.actions["LookH"];
        _rearViewAction = _playerInput.actions["Rear View"];
        _lightsAction = _playerInput.actions["Lights"];
        _gearsAction = _playerInput.actions["Gears"];
        _pauseAction = _playerInput.actions["Pause"];
        _changeCameraAction = _playerInput.actions["ChangeCamera"];
        _handbrakeAction = _playerInput.actions["Handbrake"];
    }
    private void UpdateInputs()
    {
        drive = _driveAction;
        steer = _steerAction;
        lookH = _lookHAction;
        rearView = _rearViewAction;
        lights = _lightsAction;
        gears = _gearsAction;
        pause = _pauseAction;
        changeCamera = _changeCameraAction;
        handbrake = _handbrakeAction;
    }
}

/*{"bindings":[{"action":"Car/Drive","id":"ffd6ade5-610b-4c4b-8dee-574ba69d9c42","path":"<Keyboard>/w","interactions":"null","processors":"null"},
 *{"action":"Car/Drive","id":"b3990f75-c2d0-4f19-951d-0f721c640c5c","path":"<Keyboard>/s","interactions":"null","processors":"null"},
 *{"action":"Car/Steer","id":"c62f5f82-8f10-4158-8898-b6aade11e983","path":"<Keyboard>/d","interactions":"null","processors":"null"},
 *{"action":"Car/Steer","id":"acf2da0c-15f5-482c-8c03-6bbe0cb55df0","path":"<Keyboard>/a","interactions":"null","processors":"null"},
 *{"action":"Car/Gears","id":"85944a08-bb1e-4867-beba-fcf3ee4491ad","path":"<Keyboard>/space","interactions":"null","processors":"null"},
 *{"action":"Car/Gears","id":"53c28f44-9f82-4c0b-b14b-2296c862f73a","path":"<Keyboard>/leftShift","interactions":"null","processors":"null"},
 *{"action":"Car/Gears","id":"ca89d96d-831c-4b00-8393-e8e2022c1c7c","path":"<Gamepad>/buttonEast","interactions":"null","processors":"null"},
 *{"action":"Car/Gears","id":"111fa7c6-20b3-44ae-acf0-d2da1e5c71e0","path":"<Gamepad>/buttonNorth","interactions":"null","processors":"null"},
 *{"action":"Car/Drive","id":"a4f9854f-47de-4aea-a71c-2db7b921850d","path":"<DualSenseGamepadHID>/leftTriggerButton","interactions":"null","processors":"null"},
 *{"action":"Car/Drive","id":"57953817-9eaf-4aae-8176-a9783efedc7a","path":"<DualSenseGamepadHID>/rightTriggerButton","interactions":"null","processors":"null"},
 *{"action":"Car/Steer","id":"e386cb84-8116-4e05-9bbd-0ae9741e9649","path":"<DualSenseGamepadHID>/rightTriggerButton","interactions":"null","processors":"null"},
 *{"action":"Car/ChangeCamera","id":"7e712078-e875-498f-9395-940f3bf438b3","path":"<Keyboard>/q","interactions":"null","processors":"null"},
 *{"action":"Car/ChangeCamera","id":"065a2343-82f4-4326-9dca-adc4f382330e","path":"<Gamepad>/rightStickPress","interactions":"null","processors":"null"},
 *{"action":"Car/Rear View","id":"9a29506b-6034-4b12-8b9f-72c7b0f6822a","path":"<Keyboard>/leftCtrl","interactions":"null","processors":"null"},
 *{"action":"Car/Rear View","id":"0f39cf3d-af9e-4ffa-bf54-a7c55cf1957f","path":"<Gamepad>/buttonSouth","interactions":"null","processors":"null"},
 *{"action":"Car/Lights","id":"ad60214e-7208-4a83-8ac1-6af5de8f8495","path":"<Keyboard>/l","interactions":"null","processors":"null"},
 *{"action":"Car/Lights","id":"a1011356-0ed2-406e-93db-61f164faef5f","path":"<Gamepad>/leftStickPress","interactions":"null","processors":"null"},
 *{"action":"Car/Handbrake","id":"4586efe6-56fe-433c-96e7-6a76b2b4f10b","path":"<Keyboard>/b","interactions":"null","processors":"null"},
 *{"action":"Car/Handbrake","id":"96829fc3-05c5-4a61-90b1-1fd1ffff4e27","path":"<Gamepad>/buttonWest","interactions":"null","processors":"null"}]}
UnityEngine.MonoBehaviour:print (object)
RebindSaveLoad:LoadJson () (at Assets/Samples/Input System/1.7.0/Rebinding UI/RebindSaveLoad.cs:19)
RebindSaveLoad:OnEnable () (at Assets/Samples/Input System/1.7.0/Rebinding UI/RebindSaveLoad.cs:11)*/
