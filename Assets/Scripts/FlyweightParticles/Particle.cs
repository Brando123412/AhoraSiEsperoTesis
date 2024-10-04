using UnityEngine;

public class Particle
{
    public Vector3 Position { get; private set; }
    public float Lifetime { get; private set; }
    private readonly ParticleSO flyweight;
    private GameObject particleObjectInstance;
    private MaterialPropertyBlock materialPropertyBlock;
    private Renderer renderer;

    public Particle(Vector3 position, float lifetime, ParticleSO flyweight, GameObject particleObject, Transform parentObject)
    {
        Position = position;
        Lifetime = lifetime;
        this.flyweight = flyweight;

        particleObjectInstance = GameObject.Instantiate(particleObject);
        particleObjectInstance.transform.position = Position;
        particleObjectInstance.transform.parent = parentObject;

        renderer = particleObjectInstance.GetComponent<Renderer>();
        renderer.material = flyweight.material;

        materialPropertyBlock = new MaterialPropertyBlock();
        materialPropertyBlock.SetColor("_Color", flyweight.color);
        renderer.SetPropertyBlock(materialPropertyBlock);
    }

    public void Update(float deltaTime)
    {
        Lifetime -= deltaTime;
        /*Position += Vector3.up * flyweight.speed * deltaTime;
        particleObjectInstance.transform.position = Position; */

        if (Lifetime <= 0)
        {
            GameObject.Destroy(particleObjectInstance);
        }
    }
}