using System.Collections.Generic;
using UnityEngine;

public class ParticleCollisionHandler : MonoBehaviour
{
    public ParticleSystem particleSystem; // Arrastra tu sistema de partículas aquí
    public ParticleSystem explosionParticles; // Sistema de partículas para la explosión

    private List<ParticleCollisionEvent> collisionEvents; // Lista para eventos de colisión

    void Start()
    {
        // Inicializa la lista
        collisionEvents = new List<ParticleCollisionEvent>();
    }

    void OnParticleCollision(GameObject other)
    {
        // Limpia la lista antes de usarla
        collisionEvents.Clear();

        // Obtén los eventos de colisión y guárdalos en la lista
        int numCollisionEvents = particleSystem.GetCollisionEvents(other, collisionEvents);

        // Recorre los eventos de colisión
        for (int i = 0; i < numCollisionEvents; i++)
        {
            // Obtén la posición de colisión
            Vector3 collisionPosition = collisionEvents[i].intersection;

            // Instancia un nuevo sistema de partículas para la explosión en la posición de colisión
            Instantiate(explosionParticles, collisionPosition, Quaternion.identity);
        }
    }
}
