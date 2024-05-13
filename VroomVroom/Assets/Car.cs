//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Car.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @CarClass: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @CarClass()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Car"",
    ""maps"": [
        {
            ""name"": ""Car"",
            ""id"": ""05eeb9f9-bfa4-45fc-b448-f4b461578943"",
            ""actions"": [
                {
                    ""name"": ""Drive"",
                    ""type"": ""Value"",
                    ""id"": ""601db858-6fe8-4aad-b7d5-2f4adb2c8131"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Steer"",
                    ""type"": ""Value"",
                    ""id"": ""db6e3b59-950e-4958-a6e1-5da832383766"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""b704fe28-2b35-4531-a264-8ac843f3001e"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Gears"",
                    ""type"": ""Button"",
                    ""id"": ""f02065ff-4509-4d1b-a324-d0c9dda4733d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Value"",
                    ""id"": ""c9896eb1-cdbf-47d4-a10a-ee60e7aca7f1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ChangeCamera"",
                    ""type"": ""Button"",
                    ""id"": ""3427dfea-b4dc-4ae6-8ddf-239226056a0d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""KBM"",
                    ""id"": ""97f43d98-6b50-4fbd-bb13-e88bd9994443"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drive"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b3990f75-c2d0-4f19-951d-0f721c640c5c"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Drive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ffd6ade5-610b-4c4b-8dee-574ba69d9c42"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Drive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""KBM"",
                    ""id"": ""64222291-48ff-425d-896f-a4c548294872"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""acf2da0c-15f5-482c-8c03-6bbe0cb55df0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""c62f5f82-8f10-4158-8898-b6aade11e983"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f0f7f66b-eb1c-448a-b131-c7c44fd3b02e"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM;Playstation Controller;Xbox Controller;Sim Rig"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""24b82a3b-07bf-4931-85da-f93f56860d89"",
                    ""path"": ""<DualShockGamepad>/rightStick/X"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Playstation Controller"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""KBM"",
                    ""id"": ""7de0b7e4-bb13-47a1-ac0b-f3625a983c2b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gears"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""53c28f44-9f82-4c0b-b14b-2296c862f73a"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Gears"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""85944a08-bb1e-4867-beba-fcf3ee4491ad"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Gears"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""PS"",
                    ""id"": ""af9cb109-1d03-48f7-8932-a1cb599a9569"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gears"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""111fa7c6-20b3-44ae-acf0-d2da1e5c71e0"",
                    ""path"": ""<DualShockGamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Playstation Controller"",
                    ""action"": ""Gears"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""ca89d96d-831c-4b00-8393-e8e2022c1c7c"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Playstation Controller"",
                    ""action"": ""Gears"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b93c06b4-2962-475c-9bdc-6b32fbfa7d47"",
                    ""path"": ""<DualShockGamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Playstation Controller"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""PS"",
                    ""id"": ""3336bc49-e05f-470e-bafd-427fa3d2b0ea"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drive"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""57953817-9eaf-4aae-8176-a9783efedc7a"",
                    ""path"": ""<DualShockGamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Playstation Controller"",
                    ""action"": ""Drive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a4f9854f-47de-4aea-a71c-2db7b921850d"",
                    ""path"": ""<DualShockGamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Playstation Controller"",
                    ""action"": ""Drive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Xbox"",
                    ""id"": ""dd1beedc-c0ee-4f44-8d8b-2da8b4bf895e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drive"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5ff75949-3c1a-4a2e-81f3-5e1cb4ca58a1"",
                    ""path"": ""<XInputController>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Controller"",
                    ""action"": ""Drive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""218057a6-3af6-4058-88e3-4b89f0d4dfed"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Controller"",
                    ""action"": ""Drive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0ae433cd-650f-4352-b474-c7dda14859ef"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Controller"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Xbox"",
                    ""id"": ""fbc628de-d697-402b-ad77-acf485094611"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Gears"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8d910d1d-b4be-4314-b295-8180127f5c3e"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Controller"",
                    ""action"": ""Gears"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""b994c438-ecf3-4ad2-9eb3-abde40269225"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Controller"",
                    ""action"": ""Gears"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e2657abc-1756-4ad2-8e4f-4de4a3dd30f6"",
                    ""path"": ""<XInputController>/rightStick/X"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Controller"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a40f86eb-0177-4d00-8c8f-af072786c3bf"",
                    ""path"": ""<XInputController>/leftStick/X"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Controller"",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fc54a977-239c-40ca-a7a3-4be600165412"",
                    ""path"": ""<DualShockGamepad>/leftStick/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Steer"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7e712078-e875-498f-9395-940f3bf438b3"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""ChangeCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""065a2343-82f4-4326-9dca-adc4f382330e"",
                    ""path"": ""<DualShockGamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Playstation Controller"",
                    ""action"": ""ChangeCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bbfb4462-f933-4163-9521-d97d85e42c78"",
                    ""path"": ""<XInputController>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Controller"",
                    ""action"": ""ChangeCamera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Sim Rig"",
            ""id"": ""91fe5248-7a74-4a3f-83e3-6b445f8d1312"",
            ""actions"": [
                {
                    ""name"": ""Drive"",
                    ""type"": ""Value"",
                    ""id"": ""0ef6971d-1ca3-41d9-8c8f-cafb8c3df91d"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Go"",
                    ""id"": ""3216af8f-b56c-4017-bdf3-d847044efcba"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Drive"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""400b9164-5b9e-43a5-97ce-0a2a729c50db"",
                    ""path"": ""<HID>/{Back}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Sim Rig"",
                    ""action"": ""Drive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""feb6b0d5-9a28-49cc-8fae-71462c62a68e"",
                    ""path"": ""<HID>/{Forward}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Sim Rig"",
                    ""action"": ""Drive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KBM"",
            ""bindingGroup"": ""KBM"",
            ""devices"": []
        },
        {
            ""name"": ""Playstation Controller"",
            ""bindingGroup"": ""Playstation Controller"",
            ""devices"": []
        },
        {
            ""name"": ""Xbox Controller"",
            ""bindingGroup"": ""Xbox Controller"",
            ""devices"": []
        },
        {
            ""name"": ""Sim Rig"",
            ""bindingGroup"": ""Sim Rig"",
            ""devices"": []
        }
    ]
}");
        // Car
        m_Car = asset.FindActionMap("Car", throwIfNotFound: true);
        m_Car_Drive = m_Car.FindAction("Drive", throwIfNotFound: true);
        m_Car_Steer = m_Car.FindAction("Steer", throwIfNotFound: true);
        m_Car_Look = m_Car.FindAction("Look", throwIfNotFound: true);
        m_Car_Gears = m_Car.FindAction("Gears", throwIfNotFound: true);
        m_Car_Pause = m_Car.FindAction("Pause", throwIfNotFound: true);
        m_Car_ChangeCamera = m_Car.FindAction("ChangeCamera", throwIfNotFound: true);
        // Sim Rig
        m_SimRig = asset.FindActionMap("Sim Rig", throwIfNotFound: true);
        m_SimRig_Drive = m_SimRig.FindAction("Drive", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Car
    private readonly InputActionMap m_Car;
    private List<ICarActions> m_CarActionsCallbackInterfaces = new List<ICarActions>();
    private readonly InputAction m_Car_Drive;
    private readonly InputAction m_Car_Steer;
    private readonly InputAction m_Car_Look;
    private readonly InputAction m_Car_Gears;
    private readonly InputAction m_Car_Pause;
    private readonly InputAction m_Car_ChangeCamera;
    public struct CarActions
    {
        private @CarClass m_Wrapper;
        public CarActions(@CarClass wrapper) { m_Wrapper = wrapper; }
        public InputAction @Drive => m_Wrapper.m_Car_Drive;
        public InputAction @Steer => m_Wrapper.m_Car_Steer;
        public InputAction @Look => m_Wrapper.m_Car_Look;
        public InputAction @Gears => m_Wrapper.m_Car_Gears;
        public InputAction @Pause => m_Wrapper.m_Car_Pause;
        public InputAction @ChangeCamera => m_Wrapper.m_Car_ChangeCamera;
        public InputActionMap Get() { return m_Wrapper.m_Car; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CarActions set) { return set.Get(); }
        public void AddCallbacks(ICarActions instance)
        {
            if (instance == null || m_Wrapper.m_CarActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CarActionsCallbackInterfaces.Add(instance);
            @Drive.started += instance.OnDrive;
            @Drive.performed += instance.OnDrive;
            @Drive.canceled += instance.OnDrive;
            @Steer.started += instance.OnSteer;
            @Steer.performed += instance.OnSteer;
            @Steer.canceled += instance.OnSteer;
            @Look.started += instance.OnLook;
            @Look.performed += instance.OnLook;
            @Look.canceled += instance.OnLook;
            @Gears.started += instance.OnGears;
            @Gears.performed += instance.OnGears;
            @Gears.canceled += instance.OnGears;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
            @ChangeCamera.started += instance.OnChangeCamera;
            @ChangeCamera.performed += instance.OnChangeCamera;
            @ChangeCamera.canceled += instance.OnChangeCamera;
        }

        private void UnregisterCallbacks(ICarActions instance)
        {
            @Drive.started -= instance.OnDrive;
            @Drive.performed -= instance.OnDrive;
            @Drive.canceled -= instance.OnDrive;
            @Steer.started -= instance.OnSteer;
            @Steer.performed -= instance.OnSteer;
            @Steer.canceled -= instance.OnSteer;
            @Look.started -= instance.OnLook;
            @Look.performed -= instance.OnLook;
            @Look.canceled -= instance.OnLook;
            @Gears.started -= instance.OnGears;
            @Gears.performed -= instance.OnGears;
            @Gears.canceled -= instance.OnGears;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
            @ChangeCamera.started -= instance.OnChangeCamera;
            @ChangeCamera.performed -= instance.OnChangeCamera;
            @ChangeCamera.canceled -= instance.OnChangeCamera;
        }

        public void RemoveCallbacks(ICarActions instance)
        {
            if (m_Wrapper.m_CarActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICarActions instance)
        {
            foreach (var item in m_Wrapper.m_CarActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CarActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CarActions @Car => new CarActions(this);

    // Sim Rig
    private readonly InputActionMap m_SimRig;
    private List<ISimRigActions> m_SimRigActionsCallbackInterfaces = new List<ISimRigActions>();
    private readonly InputAction m_SimRig_Drive;
    public struct SimRigActions
    {
        private @CarClass m_Wrapper;
        public SimRigActions(@CarClass wrapper) { m_Wrapper = wrapper; }
        public InputAction @Drive => m_Wrapper.m_SimRig_Drive;
        public InputActionMap Get() { return m_Wrapper.m_SimRig; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(SimRigActions set) { return set.Get(); }
        public void AddCallbacks(ISimRigActions instance)
        {
            if (instance == null || m_Wrapper.m_SimRigActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_SimRigActionsCallbackInterfaces.Add(instance);
            @Drive.started += instance.OnDrive;
            @Drive.performed += instance.OnDrive;
            @Drive.canceled += instance.OnDrive;
        }

        private void UnregisterCallbacks(ISimRigActions instance)
        {
            @Drive.started -= instance.OnDrive;
            @Drive.performed -= instance.OnDrive;
            @Drive.canceled -= instance.OnDrive;
        }

        public void RemoveCallbacks(ISimRigActions instance)
        {
            if (m_Wrapper.m_SimRigActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ISimRigActions instance)
        {
            foreach (var item in m_Wrapper.m_SimRigActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_SimRigActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public SimRigActions @SimRig => new SimRigActions(this);
    private int m_KBMSchemeIndex = -1;
    public InputControlScheme KBMScheme
    {
        get
        {
            if (m_KBMSchemeIndex == -1) m_KBMSchemeIndex = asset.FindControlSchemeIndex("KBM");
            return asset.controlSchemes[m_KBMSchemeIndex];
        }
    }
    private int m_PlaystationControllerSchemeIndex = -1;
    public InputControlScheme PlaystationControllerScheme
    {
        get
        {
            if (m_PlaystationControllerSchemeIndex == -1) m_PlaystationControllerSchemeIndex = asset.FindControlSchemeIndex("Playstation Controller");
            return asset.controlSchemes[m_PlaystationControllerSchemeIndex];
        }
    }
    private int m_XboxControllerSchemeIndex = -1;
    public InputControlScheme XboxControllerScheme
    {
        get
        {
            if (m_XboxControllerSchemeIndex == -1) m_XboxControllerSchemeIndex = asset.FindControlSchemeIndex("Xbox Controller");
            return asset.controlSchemes[m_XboxControllerSchemeIndex];
        }
    }
    private int m_SimRigSchemeIndex = -1;
    public InputControlScheme SimRigScheme
    {
        get
        {
            if (m_SimRigSchemeIndex == -1) m_SimRigSchemeIndex = asset.FindControlSchemeIndex("Sim Rig");
            return asset.controlSchemes[m_SimRigSchemeIndex];
        }
    }
    public interface ICarActions
    {
        void OnDrive(InputAction.CallbackContext context);
        void OnSteer(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnGears(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnChangeCamera(InputAction.CallbackContext context);
    }
    public interface ISimRigActions
    {
        void OnDrive(InputAction.CallbackContext context);
    }
}
