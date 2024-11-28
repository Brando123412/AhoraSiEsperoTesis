using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionParticula : MonoBehaviour
{
    void OnParticleCollision(GameObject other)
    {
        // Verifica si el objeto que colisionó es relevante
        Debug.Log("Colisión detectada con: " + other.name);

        // Lógica personalizada
        // Ejemplo: Cambiar color del objeto tras la colisión
        GetComponent<Renderer>().material.color = Color.red;
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trruiger detectada con: " + other.name);
    }
}
