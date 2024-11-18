using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolvoDisperso : MonoBehaviour
{
    private ParticleSystem ps;
    private ParticleSystem.EmissionModule emissionModule;
    private ParticleSystem.MainModule mainModule;

    void Start()
    {
        ps = GetComponent<ParticleSystem>();
        emissionModule = ps.emission;
        mainModule = ps.main;
    }

    private void OnParticleCollision(GameObject other)
    {
        // Verifica si el objeto de colisión es el objeto de limpieza
        if (other.CompareTag("Limpieza"))
        {
            print("Hola");
            // Activa la emisión de partículas para simular dispersión
            emissionModule.rateOverTime = 50; // Emitirá partículas rápidamente al interactuar

            // Aumenta la velocidad y ajusta el tamaño para dispersión
            mainModule.startSpeed = 2.5f; // Partículas se dispersan rápidamente
            mainModule.startLifetime = 1.5f; // Vida breve para efecto de desaparición
            mainModule.startSize = 0.1f; // Partículas más pequeñas al dispersarse
        }
    }
}
