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

    private List<ParticleCollisionEvent> collisionEvents; // Lista para almacenar los eventos de colisi�n

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
            // Obtener los eventos de colisi�n
            int numCollisionEvents = particleSystem.GetCollisionEvents(other, collisionEvents);

            // Iterar sobre cada part�cula que colision�
            for (int i = 0; i < numCollisionEvents; i++)
            {
                Vector3 collisionPosition = collisionEvents[i].intersection; // Posici�n de la colisi�n
                Vector3 direccionSoplado = (collisionPosition - other.transform.position).normalized;

                AplicarFuerzaIndividual(collisionPosition, direccionSoplado);
            }

            cantidadCollision += Time.deltaTime;
        }
    }

    private void AplicarFuerzaIndividual(Vector3 posicionParticula, Vector3 direccion)
    {
        // Configurar la fuerza para afectar part�culas individuales
        forceModule.enabled = true;
        forceModule.space = ParticleSystemSimulationSpace.World;

        // Aplicar la fuerza individualmente (basada en la posici�n)
        forceModule.x = direccion.x * forceVelocity;
        forceModule.y = direccion.y * forceVelocity;
        forceModule.z = direccion.z * forceVelocity;

        Debug.Log($"Aplicando fuerza en part�cula en posici�n {posicionParticula}");
    }

    public void DetenerSoplado()
    {
        emissionModule.rateOverTime = 0;
        forceModule.enabled = false;
    }
}
