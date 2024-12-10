using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TareaCintaDesfasada : MonoBehaviour
{
    [SerializeField]CantidadTareasGame gameTareasGame;
    public void CompletarTarea()
    {
        print("asdsad");
        gameTareasGame.ControlTareas(4, 1);
    }
}
