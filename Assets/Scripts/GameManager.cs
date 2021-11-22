using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class GameManager : MonoBehaviour
{   
    private float _timer = 0f;
    private static float _score = 0f;
    private static int _comboLenght = 0;
    private static float _comboMultiplier = 0f;

    private void Start()
    {
        
    }
    
    private void Update()
    {
        _timer += Time.fixedDeltaTime;
    }

    public static void Scoring(float scoreModifier)
    {
        if (scoreModifier == 200)
        {
            _score += scoreModifier * (1f + _comboMultiplier);
            _comboLenght++;
            _comboMultiplier += 0.1f;
        }
        else if (scoreModifier == 100)
        {
            _score -= scoreModifier;
            _comboLenght = 0;
            _comboMultiplier = 0;
        }
        Debug.Log("Combo : " + _comboLenght);
        Debug.Log("Score : " + _score);
        return;
    }
}
