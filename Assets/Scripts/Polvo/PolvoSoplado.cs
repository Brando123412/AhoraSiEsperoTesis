using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolvoSoplado : MonoBehaviour
{
    private ParticleSystem particleSystem;
    private ParticleSystem.MainModule mainModule;
    private ParticleSystem.ForceOverLifetimeModule forceModule;
    private ParticleSystem.EmissionModule emissionModule;

    public Transform direccionSoplado; // La dirección hacia la cual soplar el polvo

    void Start()
    {
        particleSystem = GetComponent<ParticleSystem>();
        mainModule = particleSystem.main;
        forceModule = particleSystem.forceOverLifetime;
        emissionModule = particleSystem.emission;

        // Configuración inicial para el polvo acumulado (sin movimiento)
        emissionModule.rateOverTime = 0;
        mainModule.startSpeed = 0.1f;
    }

    public void ActivarSoplado()
    {
        // Configura el módulo de emisión para que el polvo empiece a dispersarse
        emissionModule.rateOverTime = 50; // Número de partículas dispersadas

        // Cambia la dirección de las partículas hacia el suelo con fuerza
        forceModule.enabled = true;
        forceModule.space = ParticleSystemSimulationSpace.World;

        // Direcciona las partículas hacia abajo en un ángulo
        Vector3 direccion = (transform.position -direccionSoplado.position).normalized;
        forceModule.x = direccion.x * 5; // Ajusta la fuerza en X
        forceModule.y = direccion.y * 5; // Ajusta la fuerza en Y para direccionar hacia el suelo
        forceModule.z = direccion.z * 5; // Ajusta la fuerza en Z
    }
    public void DetenerSoplado()
    {
        emissionModule.rateOverTime = 0; // Detiene la emisión de partículas
        forceModule.enabled = false; // Desactiva la fuerza para las partículas restantes
    }
}
