using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TareasGame", menuName = "ScriptableObjects/TareasGame", order = 1)]
public class CantidadTareasGame : ScriptableObject
{
    [SerializeField] int[] listaTareas;

    [SerializeField] GameEvent[] listTareasSO;
    public bool[] verificadoTarea;
    
    public void ControlTareas(int index, int tarea)
    {
        if (tarea ==1) {
            listaTareas[index] += tarea;
        } 
        else if (tarea == 0)
        {
            listaTareas[index] -= tarea;
        }
        VerificarTareas(index);
    }
    private void VerificarTareas(int indexToArray)
    {
        switch (indexToArray)
        {
            case 0:
                if (listaTareas[indexToArray] >=2)//Primera puerta
                {
                    listTareasSO[indexToArray].Raise();
                    verificadoTarea[indexToArray] = true;
                }          
                break;
            case 1:
                if (listaTareas[indexToArray] >= 1 && verificadoTarea[indexToArray-1])// segunda puerta
                {
                    listTareasSO[indexToArray].Raise();
                    verificadoTarea[indexToArray] = true;
                }

                break;
            case 2:
                if (listaTareas[indexToArray] >= 2)//Cambiar Rodillos
                {
                    listTareasSO[indexToArray].Raise();
                    verificadoTarea[indexToArray] = true;
                }

                break;
            case 3:
                if (listaTareas[indexToArray] >= 10)//Mover Obstaculos
                {
                    listTareasSO[indexToArray].Raise();
                    verificadoTarea[indexToArray] = true;
                }
                break;
            case 4:
                if (listaTareas[indexToArray] >= 1)//Reportar Cinta Desfasada
                {
                    listTareasSO[indexToArray].Raise();
                    verificadoTarea[indexToArray] = true;
                }
                break;
            case 5:
                if (listaTareas[indexToArray] >= 1)//Reportar Cinta Desgastada
                {
                    listTareasSO[indexToArray].Raise();
                    verificadoTarea[indexToArray] = true;
                }
                break;
            case 6:
                if (listaTareas[indexToArray] >= 1)//Limpiar Polvo
                {
                    listTareasSO[indexToArray].Raise();
                    verificadoTarea[indexToArray] = true;
                }
                break;
            case 7:
                if (listaTareas[indexToArray] >= 1)
                {
                    listTareasSO[indexToArray].Raise();
                    verificadoTarea[indexToArray] = true;
                }
                break;
            default:
                break;
        }

    }
}
