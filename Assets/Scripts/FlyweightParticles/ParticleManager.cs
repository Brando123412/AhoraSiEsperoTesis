using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    public List<ParticleSO> particleSO;
    private List<Particle> particles = new List<Particle>();
    [SerializeField] private GameObject particleObject;
    [SerializeField] private float timeCreateParticle;
    [SerializeField] private Transform positionSpanw;

    
    void Start()
    {
        if (particleSO.Count > 0)
        {
            CreateParticle(positionSpanw.position, particleSO[0], 5.0f);
        }
        InvokeRepeating("CreateParticleMetodo", 1,timeCreateParticle);
    }


    void Update()
    {
        float deltaTime = Time.deltaTime;
        UpdateParticles(deltaTime);
    }
    void CreateParticleMetodo()
    {
        CreateParticle(positionSpanw.position, particleSO[0], 5.0f);
    }

    public void CreateParticle(Vector3 position, ParticleSO flyweight, float lifetime)
    {
        Particle particle = new Particle(position, lifetime, flyweight, particleObject,transform);
        particles.Add(particle);
    }

    public void UpdateParticles(float deltaTime)
    {
        for (int i = particles.Count - 1; i >= 0; i--)
        {
            particles[i].Update(deltaTime);
            if (particles[i].Lifetime <= 0)
            {
                particles.RemoveAt(i);
            }
        }
    }

}