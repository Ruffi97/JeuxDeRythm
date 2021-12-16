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

    [System.Obsolete]
    public static void isPressed()
    {
        int success = 3;
        
        if (Notes.Dest.GetComponentInChildren<SpriteRenderer>().material.color == Color.white)
        {
            if (Notes._distance >= 0.0000000000001f && Notes._distance <= 0.06f)
            {
                success = 1;
                GameManager.Scoring(300f);
            }
            else if (Notes._distance >= 0.07f && Notes._distance <= 0.12f)
            {
                success = 2;
                GameManager.Scoring(150f);
            }
            Destroy(GameObject.FindGameObjectWithTag("note"));
            GameManager.Scoring(100f);
            Cursors.SpawnParticles(success);
        }
        else 
        { 
            success = 3;
            GameManager.Scoring(100f);
            Cursors.SpawnParticles(success);
            
        }
    }
}
