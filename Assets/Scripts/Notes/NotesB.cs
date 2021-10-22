using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotesB : MonoBehaviour
{
    GameObject dest;
    Vector3 destPos;
    public float speed;

    void Start()
    {
        dest = GameObject.FindGameObjectWithTag("destB");
        destPos = dest.transform.position;
    }

    void Update()
    {
        transform.position += new Vector3((destPos.x + 4f) - transform.position.x, (destPos.y - 3.5f) - transform.position.y, 0) * speed * Time.deltaTime;
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
