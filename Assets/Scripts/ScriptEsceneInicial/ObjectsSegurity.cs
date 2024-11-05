using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsSegurity : MonoBehaviour
{
    [SerializeField] int numeroTarea;
    [SerializeField] private GameIntEvent gameEvent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            gameEvent.Raise(numeroTarea);
            gameObject.SetActive(false);
        }
    }
}
