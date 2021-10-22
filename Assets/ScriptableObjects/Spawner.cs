using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Spawners")]
public class Spawner : ScriptableObject
{
    [SerializeField]
    private GameObject SpawnPoint;
    [SerializeField]
    private GameObject note;
    float _timer = 0f;
    [SerializeField]
    private  float count;
    
    void Update()
    {  
        if (_timer >= count)
        {
            Instantiate(note, SpawnPoint.transform.position, Quaternion.identity);
            _timer = 0f;
        }

        _timer += Time.deltaTime;
    }
}
