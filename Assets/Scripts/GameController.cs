using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypeHerramientas {Perno, Tuerca, Destornillador, Llave, Candato, Manguera}

public class GameController : MonoBehaviour
{
    [SerializeField] SOHerramientas soHerramientas;
    private void Awake()
    {
        soHerramientas.RetunrObject(Vector3.zero);
    }

    

}
