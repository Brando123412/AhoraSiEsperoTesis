using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorTareas : MonoBehaviour
{
    CantidadTareasGame cantidadTareasSo;

    [Header ("Para tarea1")]
    GameEvent Event1;

    [Header("Para tarea2")]
    GameEvent Event2;

    [Header("Para tarea3")]
    GameEvent Event3;
    private void Start()
    {
        /*for (int i = 0;i<cantidadTareasSo.verificadoTarea.Length;i++)
        {
            if (cantidadTareasSo.verificadoTarea[i])
            {
                Event1.Raise();
            }
        }*/
        
    }
}
