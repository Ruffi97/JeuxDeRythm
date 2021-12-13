using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class GameManager : MonoBehaviour
{   
    [SerializeField]
    private List<Transform> _spawnPointsList = new List<Transform>();
    [SerializeField]
    private AudioSource audio;
    [SerializeField]
    private GameObject _note;
    
    private float _timer = 0f;
    private static float _score = 0f;
    private static int _comboLenght = 0;
    private static float _comboMultiplier = 0f;
    public Note[] chanson1;
    
    private void Start()
    {
        
    }
    
    private void Update()
    {
        _timer = audio.time;
        if (audio.time >= Note.spawnTime)
        {
            //Instantiate(_note, , Quaternion.identity);
        }
    }

    public static void Scoring(float scoreModifier)
    {
        if (scoreModifier == 300f)
        {
            _score += scoreModifier * (1f + _comboMultiplier);
            _comboLenght++;
            _comboMultiplier += 0.1f;
        }
        else if (scoreModifier == 150f)
        {
            _score += scoreModifier * (1f + _comboMultiplier);
            _comboLenght++;
            _comboMultiplier += 0.1f;
        }
        else if (scoreModifier == 100f)
        {
            _score -= scoreModifier;
            _comboLenght = 0;
            _comboMultiplier = 0.0f;
        }
        else { }
        Debug.Log("Combo : " + _comboLenght);
        Debug.Log("Score : " + _score);
        return;
    }
}

[Serializable]
public class Note
{
    public enum SpawnPoint
    {
        TopLeft,
        TopCornerLeft,
        TopRight, 
        TopCornerRight,
        DownLeft,
        DownCornerLeft,
        DownRight, 
        DownCornerRight
    }
    
    public SpawnPoint spawnPoint;
    public static float spawnTime;
    
}
