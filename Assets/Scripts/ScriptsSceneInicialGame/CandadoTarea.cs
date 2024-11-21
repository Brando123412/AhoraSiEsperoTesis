using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandadoTarea : MonoBehaviour
{
    [SerializeField] int tarea;
    [SerializeField] int index;

    [SerializeField] GameIntTwoEvent gameEvent;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Nivel1Tarea"))
        {
            gameEvent.Raise(index, 1);
            other.gameObject.SetActive(false);
            Debug.Log("Candado");
        }
    }
}
