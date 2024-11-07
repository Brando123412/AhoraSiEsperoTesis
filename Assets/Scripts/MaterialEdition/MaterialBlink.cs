using UnityEngine;

public class MaterialBlink : MonoBehaviour
{
    public Material material;  // Material que se va a modificar
    public float minAlpha = 0f;  // Transparencia mínima (invisible)
    public float maxAlpha = 1f;  // Transparencia máxima (totalmente visible)
    public float blinkSpeed = 1.0f;  // Velocidad de parpadeo

    private Renderer rend;
    private float lerpTime = 0f;

    void Start()
    {
        rend = GetComponent<Renderer>();
        if (material != null)
        {
            rend.material = material;
        }
    }

    void Update()
    {
        if (material != null)
        {
            // Hacer que el valor de lerpTime oscile de 0 a 1 y viceversa
            lerpTime += Time.deltaTime * blinkSpeed;
            if (lerpTime >= 1f)
            {
                lerpTime = 0f;  // Resetear el valor cuando llega a 1
            }

            // Crear una interpolación suave de la transparencia (efecto parpadeo)
            float alpha = Mathf.PingPong(lerpTime, 1f);  // Oscila entre 0 y 1
            alpha = Mathf.Lerp(minAlpha, maxAlpha, alpha);  // Interpolación entre minAlpha y maxAlpha

            // Modificar la transparencia del material
            Color color = material.color;
            color.a = alpha;  // Ajustar el componente alpha (transparencia)
            material.color = color;
        }
    }
}
