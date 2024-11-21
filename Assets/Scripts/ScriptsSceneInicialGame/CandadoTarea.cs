using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandadoTarea : MonoBehaviour
{
    [SerializeField] int tarea;

    [SerializeField] GameIntEvent gameEvent;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Nivel1Tarea"))
        {
            gameEvent.Raise(tarea-1);               
        }
    }
}
