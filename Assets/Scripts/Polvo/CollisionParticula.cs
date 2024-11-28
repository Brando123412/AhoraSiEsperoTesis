using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionParticula : MonoBehaviour
{
    void OnParticleCollision(GameObject other)
    {
        // Verifica si el objeto que colision� es relevante
        Debug.Log("Colisi�n detectada con: " + other.name);

        // L�gica personalizada
        // Ejemplo: Cambiar color del objeto tras la colisi�n
        GetComponent<Renderer>().material.color = Color.red;
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trruiger detectada con: " + other.name);
    }
}
