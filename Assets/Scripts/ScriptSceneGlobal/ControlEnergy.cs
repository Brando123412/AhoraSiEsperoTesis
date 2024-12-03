using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlEnergy : MonoBehaviour
{                                     
    [SerializeField] private Animator electrical;
    [SerializeField] private bool isElectrical = false;
    [SerializeField] private GameIntTwoEvent gameIntTwoEvent;

    public void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            ElectricalActive();
        }
    }
    public void ElectricalActive()
    {
        isElectrical = !isElectrical;
        electrical.SetBool("IsOn", isElectrical);
        if(isElectrical )
            gameIntTwoEvent.Raise(1, 1);
        else if (!isElectrical)
            gameIntTwoEvent.Raise(1, 0);
    }

}
