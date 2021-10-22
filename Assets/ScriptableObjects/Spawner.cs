using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Spawners")]
public class Spawner : ScriptableObject
{
    
    public static Transform _SpawnPoint;
    [SerializeField]
    private static GameObject _note;
    private float _timer = 0f;
    [SerializeField]
    private  float _count;
    
    void Update()
    {  
        if (_timer >= _count)
        {
            Instantiate(_note, _SpawnPoint.position, Quaternion.identity);
            _timer = 0f;
        }

        _timer += Time.deltaTime;
    }
}
