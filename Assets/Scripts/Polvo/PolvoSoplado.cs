using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolvoSoplado : MonoBehaviour
{
    private ParticleSystem particleSystem;
    private ParticleSystem.MainModule mainModule;
    private ParticleSystem.ForceOverLifetimeModule forceModule;
    private ParticleSystem.EmissionModule emissionModule;

    [SerializeField] float forceVelocity; // Velocidad del soplado
    [SerializeField] float cantidadCollision;

    private List<ParticleCollisionEvent> collisionEvents; // Lista para almacenar los eventos de colisión

    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
        mainModule = particleSystem.main;
        forceModule = particleSystem.forceOverLifetime;
        emissionModule = particleSystem.emission;

        collisionEvents = new List<ParticleCollisionEvent>(); // Inicializa la lista

        emissionModule.rateOverTime = 0;
        mainModule.startSpeed = 0.1f;
    }

    void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("Aire"))
        {
            // Obtener los eventos de colisión
            int numCollisionEvents = particleSystem.GetCollisionEvents(other, collisionEvents);

            // Iterar sobre cada partícula que colisionó
            for (int i = 0; i < numCollisionEvents; i++)
            {
                Vector3 collisionPosition = collisionEvents[i].intersection; // Posición de la colisión
                Vector3 direccionSoplado = (collisionPosition - other.transform.position).normalized;

                AplicarFuerzaIndividual(collisionPosition, direccionSoplado);
            }

            cantidadCollision += Time.deltaTime;
        }
    }

    private void AplicarFuerzaIndividual(Vector3 posicionParticula, Vector3 direccion)
    {
        // Configurar la fuerza para afectar partículas individuales
        forceModule.enabled = true;
        forceModule.space = ParticleSystemSimulationSpace.World;

        // Aplicar la fuerza individualmente (basada en la posición)
        forceModule.x = direccion.x * forceVelocity;
        forceModule.y = direccion.y * forceVelocity;
        forceModule.z = direccion.z * forceVelocity;

        Debug.Log($"Aplicando fuerza en partícula en posición {posicionParticula}");
    }

    public void DetenerSoplado()
    {
        emissionModule.rateOverTime = 0;
        forceModule.enabled = false;
    }
}
