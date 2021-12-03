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

    public static void SpawnParticles(bool isFailed)
    {
        if (!isFailed)
        {
            Notes.Dest.GetComponentInChildren<ParticleSystem>().Play();
            Notes.Dest.GetComponentInChildren<ParticleSystem>().startColor = Color.green;
            CursorTransform.DOScale(0.16f, 0.5f);
        }
        else if (isFailed)
        {
            Notes.Dest.GetComponentInChildren<ParticleSystem>().startColor = Color.red;
            Notes.Dest.GetComponentInChildren<ParticleSystem>().Play();
        }
    }
}
