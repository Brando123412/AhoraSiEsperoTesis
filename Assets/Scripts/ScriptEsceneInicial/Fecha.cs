using System;
using System.Collections.Generic;
using UnityEngine;

public class Fecha : MonoBehaviour
{
    void Start()
    {
        // Obtener la fecha y hora actual
        DateTime fechaActual = DateTime.Now;

        // Imprimir la fecha y hora en la consola
        Debug.Log("Fecha y Hora actual: " + fechaActual.ToString());
    }
}
