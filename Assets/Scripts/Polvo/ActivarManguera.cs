using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarManguera : MonoBehaviour
{
    public PolvoSoplado polvoSoplado;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            polvoSoplado.ActivarSoplado();
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            polvoSoplado.DetenerSoplado();
        }
    }
}
