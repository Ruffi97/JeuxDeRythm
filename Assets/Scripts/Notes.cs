using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    private GameObject _dest;
    private Vector3 _destPos;
    [SerializeField]
    private float _speed;

    void Start()
    {
        _dest = GameObject.FindGameObjectWithTag("dest");
        _destPos = _dest.transform.position;
    }

    void Update()
    {
        transform.position += new Vector3(_destPos.x - transform.position.x, _destPos.y - transform.position.y, 0) * _speed * Time.deltaTime;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (Input.GetKey(KeyCode.Space))
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        Destroy(gameObject);
    }
}
