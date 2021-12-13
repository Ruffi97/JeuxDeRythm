using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer[] cursors = new SpriteRenderer[4];

    private void Start()
    {
        cursors[0].material.color = Color.grey;
        cursors[1].material.color = Color.grey;
        cursors[2].material.color = Color.grey;
        cursors[3].material.color = Color.grey;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            cursors[0].material.color = Color.white;
            cursors[1].material.color = Color.grey;
            cursors[2].material.color = Color.grey;
            cursors[3].material.color = Color.grey;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            cursors[1].material.color = Color.white;
            cursors[0].material.color = Color.grey;
            cursors[2].material.color = Color.grey;
            cursors[3].material.color = Color.grey;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            cursors[2].material.color = Color.white;
            cursors[1].material.color = Color.grey;
            cursors[0].material.color = Color.grey;
            cursors[3].material.color = Color.grey;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            cursors[3].material.color = Color.white;
            cursors[1].material.color = Color.grey;
            cursors[2].material.color = Color.grey;
            cursors[0].material.color = Color.grey;
        }
    }
    public static void isPressed()
    {
        if (Notes._distance >= 0f && Notes._distance <= 0.08f && Notes.Dest.GetComponentInChildren<SpriteRenderer>().material.color == Color.white)
        {
            bool isfailed = false;
            GameManager.Scoring(200f);
            Destroy(GameObject.FindGameObjectWithTag("note"));
            Cursors.SpawnParticles(isfailed);
        }
        else 
        { 
            bool isfailed = true;
            GameManager.Scoring(100f);
            Cursors.SpawnParticles(isfailed);
            
        }
    }
}
