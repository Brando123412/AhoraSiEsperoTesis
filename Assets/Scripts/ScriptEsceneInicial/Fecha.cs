using System;
using System.Collections.Generic;
using UnityEngine;

public class Fecha : MonoBehaviour
{
    void Start()
    {
        DateTime fechaActual = DateTime.Now;

        Debug.Log("Fecha y Hora actual: " + fechaActual.ToString());
    }
}
