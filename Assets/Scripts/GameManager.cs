using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private List<ScriptableObject> _spawnerList = new List<ScriptableObject>();
    [SerializeField] 
    private List<Transform> _spawnPointsList = new List<Transform>();
    
    private int _spawnerSelection;
    Random rnd = new Random();
    void Start()
    {
        
    }

    void Update()
    {
        _spawnerSelection = rnd.Next(1, 8);
        
        if (_spawnerList[_spawnerSelection])
        {
            Spawner._SpawnPoint = _spawnPointsList[_spawnerSelection];
        }
    }
}
