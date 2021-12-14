using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager access;

    [SerializeField]
    private List<Transform> _spawnPointsList = new List<Transform>();
    [SerializeField]
    private AudioSource audio;
    [SerializeField]
    private GameObject _note;

    private Vector3 SpawnerSelected;
    private float _timer;
    private static float _score = 0f;
    private static int _comboLenght = 0;
    private static float _comboMultiplier = 0f;
    public Note[] chanson1;

    private void Start()
    {
        access = this;
    }
    private void Update()
    {
        int index = 0;
        _timer = audio.time;

        foreach (Note i in chanson1)
        {
            if (_timer >= i.spawnTime)
            {
                SpawnerSelected = new Vector3(_spawnPointsList[index].position.x, _spawnPointsList[index].position.y, _spawnPointsList[index].position.z);
                
                Instantiate(_note, SpawnerSelected, Quaternion.identity);
            }
            index++;
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
    public enum SpawnPoint : int
    {
        TopLeft,
        TopCornerLef1,
        TopRight, 
        TopCornerRight,
        DownLeft,
        DownCornerLeft,
        DownRight, 
        DownCornerRigh
    }
    
    public SpawnPoint spawnPoint;
    public float spawnTime; 
}
