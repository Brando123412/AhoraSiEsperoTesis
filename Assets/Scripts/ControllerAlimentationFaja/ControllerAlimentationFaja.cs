using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerAlimentationFaja : MonoBehaviour
{

    [SerializeField] private Animator levelPower;
    [SerializeField] private bool levelPowerActivation = false;

    public void ToggleLevelPower()
    {
        levelPowerActivation = !levelPowerActivation;
        levelPower.SetBool("IsOn", levelPowerActivation);
    }
}
