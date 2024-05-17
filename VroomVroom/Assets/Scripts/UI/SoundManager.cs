using System;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using UnityEngine.InputSystem.DualShock;
using UnityEngine.InputSystem.Users;
using UnityEngine.InputSystem.XInput;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    public InputActionAsset actions;
    CarClass carInput;
    public string inputType = "KBM";
    public InputAction input;
    [SerializeField] Slider volumeSlider;
    public List<Button> allAccels = new List<Button>();

    public GameObject KBMKeys;
    public GameObject PSKeys;
    public GameObject XboxKeys;

    public string currentControlScheme = "<Keyboard>";

    void Start()
    {
        carInput = new CarClass();

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

    //public void OnEnable()
    //{
    //    var rebinds = PlayerPrefs.GetString("rebinds");
    //    if (!string.IsNullOrEmpty(rebinds))
    //        actions.LoadBindingOverridesFromJson(rebinds);
    //}

    //public void OnDisable()
    //{
    //    var rebinds = actions.SaveBindingOverridesAsJson();
    //    PlayerPrefs.SetString("rebinds", rebinds);
    //}
    private void Update()
    {
        
        CheckDeviceType();

        //carInput.Car.Drive.GetBindingDisplayString(0);
    }
    
    void CheckDeviceType()
    {
        if (Gamepad.current != null && Gamepad.current.allControls.Any(x => x is ButtonControl button && x.IsPressed() && !x.synthetic) == true)
        {
            if (inputType != "PS" && Gamepad.current is DualShockGamepad)
            {
                switch(inputType)
                {
                    case "KBM": KBMKeys.SetActive(false); break;
                    case "Xbox": XboxKeys.SetActive(false); break;
                }
                inputType = "PS";
                currentControlScheme = "<PlayStation Controller>";
                PSKeys.SetActive(true);

            }
            else if (inputType != "Xbox" && Gamepad.current is XInputController)
            {
                switch (inputType)
                {
                    case "KBM": KBMKeys.SetActive(false); break;
                    case "PS": PSKeys.SetActive(false); break;
                }
                inputType = "Xbox";
                currentControlScheme = "<Xbox Controller>";
                XboxKeys.SetActive(true);
            }
        }
        else if (inputType != "KBM" && Input.anyKeyDown || Input.GetMouseButtonDown(0))
        {
            switch (inputType)
            {
                case "PS": PSKeys.SetActive(false); break;
                case "Xbox": XboxKeys.SetActive(false); break;
            }
            inputType = "KBM";
            KBMKeys.SetActive(true);
        }
        //print(inputType);
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
}
