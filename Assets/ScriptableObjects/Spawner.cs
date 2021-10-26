using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private List<Transform> _spawnPointsList = new List<Transform>();

    private int _spawnPointIndex;
    public static Transform _spawnPoint;
    [SerializeField]
    private GameObject _note;
    private float _timer = 0f;
    [SerializeField]
    private  float _timeBetweenNote = 3f;
    Random rnd = new Random();

    void Update()
    {
        _spawnPointIndex = rnd.Next(0, 7);
        _spawnPoint = _spawnPointsList[_spawnPointIndex];

        if (_timer >= _timeBetweenNote)
        {
            Instantiate(_note, _spawnPoint.position, Quaternion.identity);
            _timer = 0f;
        }

        _timer += Time.deltaTime;
    }
}
