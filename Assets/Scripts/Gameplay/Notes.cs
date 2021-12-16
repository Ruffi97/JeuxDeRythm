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
    }

    [System.Obsolete]
    private void Update()
    {

        FindClosestTarget();

        _position = Vector3.MoveTowards(_position, Dest.transform.position, _speed * Time.deltaTime);
        transform.position = _position;
        _distance = Vector3.Distance(Dest.transform.position, this.transform.position);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Controller.isPressed();
        }

        if (_distance <= 0.4f)
        {
            this.tag = "active";
        }

        if (_distance <= 0.001f && _distance >= 0f )
        {
            Destroy(this.gameObject);
            GameManager.Scoring(100f);
            HealthBar.HealthBarModifier(100f);
            Cursors.SpawnParticles(3);
        }
    }

    public void FindClosestTarget()
    {
        foreach (GameObject dest in _possibleDest)
        {
            _distanceToDest = Vector3.Distance(transform.position, dest.transform.position);
            if (_distanceToDest < _shortestDest)
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
}
