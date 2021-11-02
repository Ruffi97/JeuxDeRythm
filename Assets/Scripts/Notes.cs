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
    private float _shortestDest;
    private float _distanceToDest;
    public static bool _isDestroyable = false;

    void Start()
    {
        _possibleDest = GameObject.FindGameObjectsWithTag("dest");
        _shortestDest = Mathf.Infinity;
        
    }

    void Update()
    {
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

            transform.position += new Vector3(_dest.transform.position.x - transform.position.x, _dest.transform.position.y - transform.position.y,
            _dest.transform.position.z - transform.position.z) * _speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            GameManager.Scoring();
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.GetComponentInParent<Renderer>().material.color == Color.white)
        _isDestroyable = true;
        else { _isDestroyable = false; }
    }

    public void OnTriggerExit(Collider other)
    {
        _isDestroyable = false;
        Destroy(gameObject);
        GameManager.Scoring();
    }
}
