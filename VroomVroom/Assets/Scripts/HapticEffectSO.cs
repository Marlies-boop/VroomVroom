using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Haptic Effect", fileName = "HapticEffect")]
public class HapticEffectSO : ScriptableObject
{
    public enum EType
    {
        OneShot,
        Continuous
    }

    //EType staat standaard op oneshot wanneer de game gestart wordt.
    [SerializeField] EType type = EType.OneShot;

    //hoelang de vibratie duurt.
    [SerializeField] float Duration = 0f;

    //de intensiteit van de vibratie
    [SerializeField] float LowSpeedIntensity = 1f;
    //je kan hiermee de vorm van de vibratie veranderen.
    [SerializeField] AnimationCurve LowSpeedMotor;

    [SerializeField] float HighSpeedIntensity = 1f;
    [SerializeField] AnimationCurve HighSpeedMotor;

    [SerializeField] bool VariesWithDistance = false;
    [SerializeField] float MaxDistance = 25f;
    [SerializeField] AnimationCurve FallOffCurve;

    [System.NonSerialized] Vector3 EffectLocation;
    [System.NonSerialized] float Progress;
    public void Initialise(Vector3 _EffectLocation)
    {
        EffectLocation = _EffectLocation;
        Progress = 0f;
    }

    public bool Tick(Vector3 receiverPosition, out float lowSpeed, out float highSpeed)
    {
        //update Progress
        Progress += Time.deltaTime / Duration;

        //calculate the distance factor
        float distanceFactor = 1f;
        if (VariesWithDistance)
        {
            float distance = (receiverPosition - EffectLocation).magnitude;
            distanceFactor = distance >= MaxDistance ? 0f : FallOffCurve.Evaluate(distance / MaxDistance);
        }

        lowSpeed = LowSpeedIntensity * distanceFactor * LowSpeedMotor.Evaluate(Progress);
        highSpeed = HighSpeedIntensity * distanceFactor * HighSpeedMotor.Evaluate(Progress);

        //check if we are finished
        if (Progress >= 1f)
        {
            if (type == EType.OneShot)
            {
                return true;
            }

            Progress = 0f;
        }
        return false;
    }
}
