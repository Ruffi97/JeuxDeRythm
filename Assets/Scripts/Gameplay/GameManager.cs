using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class GameManager : MonoBehaviour
{
    public static GameManager access;

    [SerializeField]
    private List<Transform> spawnPoints = new List<Transform>();
    [SerializeField]
    private new AudioSource audio;
    [SerializeField]
    private GameObject _note;
    [SerializeField]
    private float BPM;
    [SerializeField]
    private float _endSheetMusic;
    [SerializeField]
    private Text _scoreText;

    private Transform SpawnerSelected;
    private float _timer;
    private int index;
    private float _beatsDelay;
    private float spawnTime = 0f;
    private static float _score = 0f;
    private static int _comboLenght = 0;
    private static float _comboMultiplier = 0f;
    private Random rnd = new Random();  

    private void Start()
    {     
        access = this;
        _beatsDelay = 60f / BPM;
    }
    private void Update()
    {
        _scoreText.text = "" + _score;
        index = rnd.Next(0, 7);
        SpawnerSelected = spawnPoints[index];

        if (audio.time >= spawnTime && audio.time <= _endSheetMusic)
        {
            Instantiate(_note, SpawnerSelected.position, Quaternion.identity);
            spawnTime += _beatsDelay;
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
        if (_score <= 0)
        {
            _score = 0f;
        }
        Debug.Log("Combo : " + _comboLenght);
        Debug.Log("Score : " + _score);
        return;
    }
}
