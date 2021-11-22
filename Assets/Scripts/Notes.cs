using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    GameObject[] _possibleDest;

    private Transform _dest;
    private GameObject _nearestDest = null;
    [SerializeField]
    private float _speed;
    private Vector3 _position;
    private float _distance;
    private float _shortestDest;
    private float _distanceToDest;
    public static bool isDestroyable = false;

    private void Start()
    {
        _position = transform.position;
        _possibleDest = GameObject.FindGameObjectsWithTag("dest");
        _shortestDest = Mathf.Infinity;
        
        foreach (GameObject dest in _possibleDest)
        {
            _distanceToDest = Vector3.Distance(transform.position, dest.transform.position);
            if(_distanceToDest < _shortestDest)
            {
                _shortestDest = _distanceToDest;
                _nearestDest = dest;
            }
        }
        if (_nearestDest != null)
        {
            _dest = _nearestDest.transform;
        }
    }

    private void Update()
    {
        
        _position += new Vector3(_dest.transform.position.x - _position.x, _dest.transform.position.y - _position.y,
            _dest.transform.position.z - _position.z) * _speed * Time.deltaTime;
        transform.position = _position;

        _distance = Vector3.Distance(_dest.transform.position, this.transform.position);
        
        if (Input.GetKey(KeyCode.Space))
        {
            if ( _distance >= 0f && _distance <= 0.4f && _dest.GetComponentInParent<Renderer>().material.color == Color.white)
            {
                
                GameManager.Scoring(200f);
                Destroy(gameObject);
            }
            else{ GameManager.Scoring(100f); }
        }
    }
}
