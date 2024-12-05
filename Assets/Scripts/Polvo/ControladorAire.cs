using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAire : MonoBehaviour
{
    public ParticleSystem sp; 

    public void activateParticle(bool isActive)
    {
        if (isActive)
        {
            sp.Play();
        }
        else
        {
            sp.Stop();
        }
    }
}
