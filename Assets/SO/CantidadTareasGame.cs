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
            listaTareas[index] = tarea++;
        } 
        else if (tarea == 0)
        {
            listaTareas[index] = tarea--;
        }
        VerificarTareas(index);
    }
    private void VerificarTareas(int indexToArray)
    {
        switch (indexToArray)
        {
            case 0:
                if (listaTareas[indexToArray] >=1)
                {
                    listTareasSO[indexToArray].Raise();
                    verificadoTarea[indexToArray] = true;
                }          
                break;
            case 1:
                break;
            case 3:
                break;
            case 4:
                break;
            default:
                break;
        }

    }
}
