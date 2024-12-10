using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TareaMangera : MonoBehaviour
{
    [SerializeField] CantidadTareasGame gameTareasGame;

    void CompletarTarea()
    {
        gameTareasGame.ControlTareas(6, 1);
    }
    public void EmpezarTarea()
    {
        InvokeRepeating("CompletarTarea",1,2);
    }
    public void fintarea()
    {
        CancelInvoke("CompletarTarea");
    }
}
