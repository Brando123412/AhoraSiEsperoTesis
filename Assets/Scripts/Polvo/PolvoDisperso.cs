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
        // Verifica si el objeto de colisi�n es el objeto de limpieza
        if (other.CompareTag("Limpieza"))
        {
            print("Hola");
            // Activa la emisi�n de part�culas para simular dispersi�n
            emissionModule.rateOverTime = 50; // Emitir� part�culas r�pidamente al interactuar

            // Aumenta la velocidad y ajusta el tama�o para dispersi�n
            mainModule.startSpeed = 2.5f; // Part�culas se dispersan r�pidamente
            mainModule.startLifetime = 1.5f; // Vida breve para efecto de desaparici�n
            mainModule.startSize = 0.1f; // Part�culas m�s peque�as al dispersarse
        }
    }
}
