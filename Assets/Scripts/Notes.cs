using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    GameObject[] _possibleDest;
    public static Transform Dest;
    private GameObject _nearestDest = null;
    [SerializeField]
    private float _speed;
    //private bool isFailed;
    private Vector3 _position;
    public static float _distance;
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
            Dest = _nearestDest.transform;
        }
    }

    private void Update()
    {       
        _position += new Vector3(Dest.transform.position.x - _position.x, Dest.transform.position.y - _position.y,
            Dest.transform.position.z - _position.z) * _speed * Time.deltaTime;
        transform.position = _position;
        _distance = Vector3.Distance(Dest.transform.position, this.transform.position);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Controller.isPressed();
        }

        if (_distance < 0.001 && _distance > 0)
        {
            Destroy(gameObject);
            //isFailed = true;
            //Cursors.SpawnParticles(isFailed);
        }
    }
}
