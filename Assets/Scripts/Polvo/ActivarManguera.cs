using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarManguera : MonoBehaviour
{
    public PolvoSoplado polvoSoplado;

    void Update()
    {
        // Activa el soplado cuando el jugador presiona un botón (por ejemplo, la tecla E)
        if (Input.GetKeyDown(KeyCode.E))
        {
            polvoSoplado.ActivarSoplado();
        }
    }
}
