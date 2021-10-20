using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public Transform SpawnPoint;
    public GameObject note;
    public float speed = 3f;
    float _timer = 0f;
    public float count;

    void Start()
    {
        
    }

    void Update()
    {  
        if (_timer >= count)
        {
            Instantiate(note, SpawnPoint.position, Quaternion.identity);
            _timer = 0f;
        }

        _timer += Time.deltaTime;
    }
}
