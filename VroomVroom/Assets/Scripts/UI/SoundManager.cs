using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.DualShock;
using UnityEngine.InputSystem.XInput;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public List<GameObject> kbmTextBinders = new List<GameObject>();
    public List<Image> gamepadTextBinders = new List<Image>();
    CarClass carInput;
    string inputType = "KBM";
    string binder;
    int bind = 0;
    public Dictionary<string, string> kbmBindings = new Dictionary<string, string>();
    public Dictionary<string, string> psBindings = new Dictionary<string, string>();
    public Dictionary<string, string> xboxBindings = new Dictionary<string, string>();
    [SerializeField] Slider volumeSlider;

    public GamepadIcons xbox;
    public GamepadIcons ps4;

    void Start()
    {
        carInput = new CarClass();

        GetBindings();


        UpdateBindingsDisplay();
        //print(kbmBindings["Brake"]);

        if (PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", +1);
            Load();
        }

        else
        {
            Load();
        }
    }
    private void Update()
    {
        
        CheckDeviceType();
        //print(carInput.Car.Drive.GetBindingForControl(carInput.Car.Drive.));
        //InputActionRebindingExtensions.GetBindingDisplayString;
        print(kbmTextBinders[0]);
    }
    
    void CheckDeviceType()
    {
        if (inputType != "KBM" && Input.anyKey || Input.GetMouseButtonDown(0))
        {
            inputType = "KBM";
            UpdateBindingsDisplay();
        }
        else if (Gamepad.current != null && Gamepad.current.allControls.Any(x => x is ButtonControl button && x.IsPressed() && !x.synthetic) == true)
        {
            if (inputType != "PS" && Gamepad.current is DualShockGamepad)
            {
                inputType = "PS";
                UpdateBindingsDisplay();
            }
            else if (inputType != "Xbox" && Gamepad.current is XInputController)
            {
                inputType = "Xbox";
                UpdateBindingsDisplay();
            }
        }
        print(inputType);
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save()
    {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }

    [Serializable]
    public struct GamepadIcons
    {
        public Sprite buttonSouth;
        public Sprite buttonNorth;
        public Sprite buttonEast;
        public Sprite buttonWest;
        public Sprite startButton;
        public Sprite selectButton;
        public Sprite leftTrigger;
        public Sprite rightTrigger;
        public Sprite leftShoulder;
        public Sprite rightShoulder;
        public Sprite dpad;
        public Sprite dpadUp;
        public Sprite dpadDown;
        public Sprite dpadLeft;
        public Sprite dpadRight;
        public Sprite leftStick;
        public Sprite rightStick;
        public Sprite leftStickPress;
        public Sprite rightStickPress;

        public Sprite GetSprite(string controlPath)
        {
            switch (controlPath)
            {
                case "A": return buttonSouth;
                case "Y": return buttonNorth;
                case "B": return buttonEast;
                case "X": return buttonWest;
                case "Menu": return startButton;
                case "View": return selectButton;
                case "LT": return leftTrigger;
                case "RT": return rightTrigger;
                case "LB": return leftShoulder;
                case "RB": return rightShoulder;
                case "dpad": return dpad;
                case "D-Pad/Up": return dpadUp;
                case "D-Pad/Down": return dpadDown;
                case "D-Pad/Left": return dpadLeft;
                case "D-Pad/Right": return dpadRight;
                case "LS/Left": return leftStick;
                case "LS/Right": return leftStick;
                case "LS/Up": return leftStick;
                case "LS/Down": return leftStick;
                case "RS/Up": return rightStick;
                case "RS/Down": return rightStick;
                case "RS/Left": return rightStick;
                case "RS/Right": return rightStick;
                case "Left Stick Press": return leftStickPress;
                case "Right Stick Press": return rightStickPress;
            }
            switch(controlPath)
            {
                case "Cross": return buttonSouth;
                case "Triangle": return buttonNorth;
                case "Circle": return buttonEast;
                case "Square": return buttonWest;
                case "Options": return startButton;
                case "Share": return selectButton;
                case "L2": return leftTrigger;
                case "R2": return rightTrigger;
                case "L1": return leftShoulder;
                case "R1": return rightShoulder;
                case "dpad": return dpad;
                case "D-Pad Up": return dpadUp;
                case "D-Pad Down": return dpadDown;
                case "D-Pad Right": return dpadLeft;
                case "D-Pad Left": return dpadRight;
                case "LS Left": return leftStick;
                case "LS Up": return leftStick;
                case "LS Down": return leftStick;
                case "LS Right": return leftStick;
                case "RS Left": return rightStick;
                case "RS Up": return rightStick;
                case "RS Down": return rightStick;
                case "RS Right": return rightStick;
                case "L3": return leftStickPress;
                case "R3": return rightStickPress;
            }
            return null;
        }
    }
    void GetBindings()
    {
        // Drive
        kbmBindings.Add("Accelerate", carInput.Car.Drive.GetBindingDisplayString(1));
        kbmBindings.Add("Brake", carInput.Car.Drive.GetBindingDisplayString(2));
        psBindings.Add("Accelerate", carInput.Car.Drive.GetBindingDisplayString(4));
        psBindings.Add("Brake", carInput.Car.Drive.GetBindingDisplayString(5));
        xboxBindings.Add("Accelerate", carInput.Car.Drive.GetBindingDisplayString(7));
        xboxBindings.Add("Brake", carInput.Car.Drive.GetBindingDisplayString(8));

        // Steer
        kbmBindings.Add("Steer Left", carInput.Car.Steer.GetBindingDisplayString(2));
        kbmBindings.Add("Steer Right", carInput.Car.Steer.GetBindingDisplayString(1));
        psBindings.Add("Steer Left", carInput.Car.Steer.GetBindingDisplayString(5));
        psBindings.Add("Steer Right", carInput.Car.Steer.GetBindingDisplayString(4));
        xboxBindings.Add("Steer Left", carInput.Car.Steer.GetBindingDisplayString(8));
        xboxBindings.Add("Steer Right", carInput.Car.Steer.GetBindingDisplayString(7));

        // Rear View
        kbmBindings.Add("Rear View", carInput.Car.RearView.GetBindingDisplayString(0));
        psBindings.Add("Rear View", carInput.Car.RearView.GetBindingDisplayString(1));
        xboxBindings.Add("Rear View", carInput.Car.RearView.GetBindingDisplayString(2));

        // Lights
        kbmBindings.Add("Lights", carInput.Car.Lights.GetBindingDisplayString(0));
        psBindings.Add("Lights", carInput.Car.Lights.GetBindingDisplayString(1));
        xboxBindings.Add("Lights", carInput.Car.Lights.GetBindingDisplayString(2));

        // Gears
        kbmBindings.Add("Gear Up", carInput.Car.Gears.GetBindingDisplayString(1));
        kbmBindings.Add("Gear Down", carInput.Car.Gears.GetBindingDisplayString(2));
        psBindings.Add("Gear Up", carInput.Car.Gears.GetBindingDisplayString(4));
        psBindings.Add("Gear Down", carInput.Car.Gears.GetBindingDisplayString(5));
        xboxBindings.Add("Gear Up", carInput.Car.Gears.GetBindingDisplayString(7));
        xboxBindings.Add("Gear Down", carInput.Car.Gears.GetBindingDisplayString(8));

        // ChangeCamera
        kbmBindings.Add("Change Camera", carInput.Car.ChangeCamera.GetBindingDisplayString(0));
        psBindings.Add("Change Camera", carInput.Car.ChangeCamera.GetBindingDisplayString(1));
        xboxBindings.Add("Change Camera", carInput.Car.ChangeCamera.GetBindingDisplayString(2));

        // Handbrake
        kbmBindings.Add("Handbrake", carInput.Car.Handbrake.GetBindingDisplayString(0));
        psBindings.Add("Handbrake", carInput.Car.Handbrake.GetBindingDisplayString(1));
        xboxBindings.Add("Handbrake", carInput.Car.Handbrake.GetBindingDisplayString(2));
    }
    void UpdateBindingsDisplay()
    {
        if (inputType == "KBM")
        {
            kbmTextBinders[0].GetComponent<TextMeshProUGUI>().text = "| " + kbmBindings["Accelerate"];
            kbmTextBinders[1].GetComponent<TextMeshProUGUI>().text = "| " + kbmBindings["Brake"];
            kbmTextBinders[2].GetComponent<TextMeshProUGUI>().text = "| " + kbmBindings["Steer Left"];
            kbmTextBinders[3].GetComponent<TextMeshProUGUI>().text = "| " + kbmBindings["Steer Right"];
            kbmTextBinders[4].GetComponent<TextMeshProUGUI>().text = "| " + kbmBindings["Handbrake"];
            kbmTextBinders[5].GetComponent<TextMeshProUGUI>().text = "| " + kbmBindings["Gear Up"];
            kbmTextBinders[6].GetComponent<TextMeshProUGUI>().text = "| " + kbmBindings["Gear Down"];
            kbmTextBinders[7].GetComponent<TextMeshProUGUI>().text = "| " + kbmBindings["Rear View"];
            kbmTextBinders[8].GetComponent<TextMeshProUGUI>().text = "| " + kbmBindings["Change Camera"];
            kbmTextBinders[9].GetComponent<TextMeshProUGUI>().text = "| " + kbmBindings["Lights"];
        }
        else if (inputType == "PS")
        {
            foreach(GameObject temp in kbmTextBinders)
            {
                temp.GetComponent<TextMeshProUGUI>().text = "|";
            }
            foreach (Image temp in gamepadTextBinders)
            {
                temp.enabled = true;
            }
            gamepadTextBinders[0].sprite = ps4.GetSprite(psBindings["Accelerate"]);
            gamepadTextBinders[1].sprite = ps4.GetSprite(psBindings["Brake"]);
            gamepadTextBinders[2].sprite = ps4.GetSprite(psBindings["Steer Left"]);
            gamepadTextBinders[3].sprite = ps4.GetSprite(psBindings["Steer Right"]);
            gamepadTextBinders[4].sprite = ps4.GetSprite(psBindings["Handbrake"]);
            gamepadTextBinders[5].sprite = ps4.GetSprite(psBindings["Gear Up"]);
            gamepadTextBinders[6].sprite = ps4.GetSprite(psBindings["Gear Down"]);
            gamepadTextBinders[7].sprite = ps4.GetSprite(psBindings["Rear View"]);
            gamepadTextBinders[8].sprite = ps4.GetSprite(psBindings["Change Camera"]);
            gamepadTextBinders[9].sprite = ps4.GetSprite(psBindings["Lights"]);

        }
    }
}
