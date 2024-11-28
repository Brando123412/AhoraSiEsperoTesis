using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolvoSoplado : MonoBehaviour
{
    private ParticleSystem particleSystem;
    private ParticleSystem.MainModule mainModule;
    private ParticleSystem.ForceOverLifetimeModule forceModule;
    private ParticleSystem.EmissionModule emissionModule;
    [SerializeField] float forceVelocity;


    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
        mainModule = particleSystem.main;
        forceModule = particleSystem.forceOverLifetime;
        emissionModule = particleSystem.emission;

        emissionModule.rateOverTime = 0;
        mainModule.startSpeed = 0.1f;
    }

    void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("Aire"))
        {
            ActivarSoplado(other.transform);
        }
    }
    private void OnParticleTrigger()
    {
        Debug.Log("Hay Triger");
    }
    public void ActivarSoplado(Transform direccionSoplado)
    {
       
        emissionModule.rateOverTime = 50;

        forceModule.enabled = true;
        forceModule.space = ParticleSystemSimulationSpace.World;

        Vector3 direccion = (transform.position -direccionSoplado.position).normalized;
        forceModule.x = direccion.x * forceVelocity; 
        forceModule.y = direccion.y * forceVelocity; 
        forceModule.z = direccion.z * forceVelocity; 
    }
    public void DetenerSoplado()
    {
        emissionModule.rateOverTime = 0; // Detiene la emisión de partículas
        forceModule.enabled = false; // Desactiva la fuerza para las partículas restantes
    }
}
