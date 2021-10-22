using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private List<ScriptableObject> _spawnerList = new List<ScriptableObject>();

    private void Start()
    {
        Random rnd = new Random();
        int SpawnerSelection = rnd.Next(1, 8);
    }
}
