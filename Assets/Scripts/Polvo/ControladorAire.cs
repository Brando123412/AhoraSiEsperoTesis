using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorAire : MonoBehaviour
{
    public ParticleSystem sp; 
    public KeyCode toggleKey = KeyCode.Space; 

    private bool isActive = false; 

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            isActive = !isActive;

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
}
