using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    GameObject dest;
    Vector3 destPos;
    public float speed;

    void Start()
    {
        dest = GameObject.FindGameObjectWithTag("dest");
        destPos = dest.transform.position;
    }

    void Update()
    {
        transform.position += new Vector3(destPos.x - transform.position.x, destPos.y - transform.position.y, 0) * speed * Time.deltaTime;
    }
}
