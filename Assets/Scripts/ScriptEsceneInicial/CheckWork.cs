using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckWork : MonoBehaviour
{

    [SerializeField] int misiones;
    [SerializeField] Toggle[] ArregloObjetivos;
    [SerializeField] int cantidadZapatos=1;
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
            }
            else
            {
                cantidadZapatos++;
                if (cantidadZapatos >= 2)
                {
                    ArregloObjetivos[i].isOn = true;
                }
            }
        }
        
    }
}
