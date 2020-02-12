using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public ParticleSystem particle;
    public void Explose(GameObject gameObject)
    {
        Instantiate(particle, gameObject.transform.position, particle.transform.rotation);
    }
}
