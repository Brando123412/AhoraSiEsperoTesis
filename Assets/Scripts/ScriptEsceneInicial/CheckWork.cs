using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class CheckWork : MonoBehaviour
{
    [SerializeField] int misiones;
    [SerializeField] Toggle[] ArregloObjetivos;
    private int cantidadZapatos =0;
    [SerializeField] XRSimpleInteractable buttonNextLevel;
    [SerializeField] int actualCantidad = 0;

    private void Awake()
    {
        misiones = ArregloObjetivos.Length;
    }
    public void CheckWorkN(int i)
    {
        i = i - 1;
        if (ArregloObjetivos[i].isOn != true)
        {
            if (i != 3)
            {
                ArregloObjetivos[i].isOn = true;
                actualCantidad++;
            }
            else
            {
                cantidadZapatos++;
                if (cantidadZapatos >= 2)
                {
                    ArregloObjetivos[i].isOn = true;
                    actualCantidad++;
                }
            }
        }
        if(actualCantidad >= misiones)
        {
            buttonNextLevel.enabled=true;
        }
    }
}
