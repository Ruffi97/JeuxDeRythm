using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField]
    private Text _scoreText;

    private float _displayScore;
    void Awake()
    {
        _displayScore = PlayerPrefs.GetFloat("_score");
    }

    void Update()
    {
        _scoreText.text = "Score : " + _displayScore;
    }
}
