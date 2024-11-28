using System.Collections.Generic;
using UnityEngine;

public class ParticleCollisionHandler : MonoBehaviour
{
    public ParticleSystem particleSystem; // Arrastra tu sistema de part�culas aqu�
    public ParticleSystem explosionParticles; // Sistema de part�culas para la explosi�n

    private List<ParticleCollisionEvent> collisionEvents; // Lista para eventos de colisi�n

    void Start()
    {
        // Inicializa la lista
        collisionEvents = new List<ParticleCollisionEvent>();
    }

    void OnParticleCollision(GameObject other)
    {
        // Limpia la lista antes de usarla
        collisionEvents.Clear();

        // Obt�n los eventos de colisi�n y gu�rdalos en la lista
        int numCollisionEvents = particleSystem.GetCollisionEvents(other, collisionEvents);

        // Recorre los eventos de colisi�n
        for (int i = 0; i < numCollisionEvents; i++)
        {
            // Obt�n la posici�n de colisi�n
            Vector3 collisionPosition = collisionEvents[i].intersection;

            // Instancia un nuevo sistema de part�culas para la explosi�n en la posici�n de colisi�n
            Instantiate(explosionParticles, collisionPosition, Quaternion.identity);
        }
    }
}
