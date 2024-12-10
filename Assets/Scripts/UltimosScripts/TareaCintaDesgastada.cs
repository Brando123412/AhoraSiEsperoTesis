using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TareaCintaDesgastada : MonoBehaviour
{
    [SerializeField] CantidadTareasGame gameTareasGame;
    public void CompletarTarea()
    {
        print("asdsad");
        gameTareasGame.ControlTareas(5,1);
    }
}
