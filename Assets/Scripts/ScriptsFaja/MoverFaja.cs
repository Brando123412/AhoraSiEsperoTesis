using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverFaja : MonoBehaviour
{
    public float velocidadX = 0.1f;  
    public float velocidadY = 0.1f; 
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>(); 
    }

    void Update()
    {
        float offsetX = Time.time * velocidadX; 
        float offsetY = Time.time * velocidadY; 

        rend.material.mainTextureOffset = new Vector2(offsetX, offsetY); 
    }
}
