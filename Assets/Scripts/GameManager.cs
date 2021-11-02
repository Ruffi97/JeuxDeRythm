using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class GameManager : MonoBehaviour
{   
    private float _timer = 0f;
    public static float score = 0f;
    public static float comboMultiplier = 0f;
    void Start()
    {
        
    }

    void Update()
    {
     
        
    }

    public static void Scoring()
    {
        if (Notes._isDestroyable)
        {
            score += 200f * (1f + comboMultiplier);
            comboMultiplier += 0.1f;
        }
        else
        {
            score -= 100f;
            comboMultiplier = 0f;
        }
        Debug.Log(score);
        return;
    }
}
