using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class Cursors : MonoBehaviour
{
    public static ParticleSystem particles;
    public static Transform CursorTransform;
    
    void Start()
    {
        particles = Notes.Dest.GetComponentInChildren<ParticleSystem>();
        CursorTransform = Notes.Dest.GetComponentInChildren<Transform>();
    }

    public static void SpawnParticles(int success)
    {
        if (success == 1)
        {
            Notes.Dest.GetComponentInChildren<ParticleSystem>().startColor = Color.green;
            Notes.Dest.GetComponentInChildren<ParticleSystem>().Play();
            CursorTransform.DOScale(0.16f, 0.5f);
        }
        else if (success == 2)
        {
            Notes.Dest.GetComponentInChildren<ParticleSystem>().startColor = Color.yellow;
            Notes.Dest.GetComponentInChildren<ParticleSystem>().Play();
        }
        else if (success == 3)
        {
            Notes.Dest.GetComponentInChildren<ParticleSystem>().startColor = Color.red;
            Notes.Dest.GetComponentInChildren<ParticleSystem>().Play();
        }
    }
}
