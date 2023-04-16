using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    private ParticleSystem particleSystemsystem;

    private void Awake()
    {
        particleSystemsystem = GetComponent<ParticleSystem>();
    }

    private void Update()
    {
        if(particleSystemsystem.isPlaying == false)
        {
            Destroy(gameObject);
        }
    }
}
