using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.InputSystem;

public class HapticManager : MonoBehaviour
{
    public static HapticManager Instance { get; private set; } = null;
    private Gamepad currentGamepad = Gamepad.current;

    List<HapticEffectSO> ActiveEffects = new List<HapticEffectSO>();
    
    void Awake()
    {
        Debug.Log("I'm waking up");
        if (Instance != null)
        {
            Debug.Log("Attempting to create second haptic manager on" + gameObject.name);
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public static HapticEffectSO PlayEffect(HapticEffectSO effect, Vector3 location)
    {
        Debug.Log("Playing effect");
        return Instance.PlayEffect_Internal(effect, location);
    }

    public static void StopEffect(HapticEffectSO effect)
    {
        Debug.Log("Stopping effect");
        Instance.StopEffect_Internal(effect);
    }

    public void Start()
    {
        // Find the first connected gamepad
        foreach (var device in Gamepad.all)
        {
            if (device != null && device.wasUpdatedThisFrame)
            {
                currentGamepad = device as Gamepad;
                Debug.Log("Gamepad connected: " + currentGamepad.name);
                break;
            }
        }

        // If no gamepad is found, display a message
        if (currentGamepad == null)
        {
            Debug.Log("No gamepad detected.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (currentGamepad == null)
        {
            currentGamepad = Gamepad.current;
            if (currentGamepad == null)
            {
                Debug.LogWarning("No gamepad found.");
                return;
            }
        }

        float lowSpeedMotor = 0f;
        float highSpeedMotor = 0f;
        Debug.Log(ActiveEffects.Count);
        for (int index = 0; index <= ActiveEffects.Count; index++)
        {
            Debug.Log($"Active effects {ActiveEffects.Count}");
            Debug.Log($"index = {index}");
            var effect = ActiveEffects[index];

            //tick the effect and clean up when finished
            float lowSpeedComponent = 0f;
            float highSpeedComponent = 0f;
            if (effect.Tick(Camera.main.transform.position, out lowSpeedComponent, out highSpeedComponent))
            {
                ActiveEffects.RemoveAt(index);
                //--index;
            }

            Debug.Log(lowSpeedComponent + ", " + highSpeedComponent);
            
            lowSpeedMotor = Mathf.Clamp01(lowSpeedComponent + lowSpeedMotor);
            Debug.Log($"lowSpeedMotor = {lowSpeedMotor}");
            highSpeedMotor = Mathf.Clamp01(highSpeedComponent + highSpeedMotor);
        }
        print(Gamepad.current);
        if (currentGamepad != null)
        {
            currentGamepad.SetMotorSpeeds(lowSpeedMotor, highSpeedMotor);
        }
    }

    void OnDestroy()
    {
        if (currentGamepad != null)
        {
            currentGamepad.SetMotorSpeeds(0f, 0f);
        }
        print(Gamepad.current);
    }

    HapticEffectSO PlayEffect_Internal(HapticEffectSO effect, Vector3 location)
    {
        var activeEffect = ScriptableObject.Instantiate(effect);

        activeEffect.Initialise(location);

        ActiveEffects.Add(activeEffect);
        Debug.Log($"Active effects {ActiveEffects.Count}");

        return activeEffect;
    }

    void StopEffect_Internal(HapticEffectSO effect)
    {
        ActiveEffects.Remove(effect);
        Debug.Log("Removing effect");
    }
}
