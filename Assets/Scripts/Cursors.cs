using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursors : MonoBehaviour
{
    public static ParticleSystem particles;
    
    void Start()
    {
        particles = Notes.Dest.GetComponentInChildren<ParticleSystem>();
        Notes.Dest.GetComponentInChildren<ParticleSystem>().startColor = Color.green;
    }

    public static void SpawnParticles(bool isFailed)
    {
        if (!isFailed)
        {
            particles.Play();
        }
        else
        {
            Notes.Dest.GetComponentInChildren<ParticleSystem>().startColor = Color.red;
            particles.Play();
        }
    }
}
