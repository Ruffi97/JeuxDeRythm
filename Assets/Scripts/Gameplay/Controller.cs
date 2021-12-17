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
        if (!PauseMenu.GameIsPaused)
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
    }
    [System.Obsolete]
    public static void isPressed()
    {
        int success = 3;
        
        if (Notes.Dest.GetComponentInChildren<SpriteRenderer>().material.color == Color.white)
        {
            if (Notes._distance >= 0 && Notes._distance <= 0.06f)
            {
                success = 1;
                GameManager.Scoring(300f);
            }
            else if (Notes._distance >= 0.061f && Notes._distance <= 0.14f)
            {
                success = 2;
                GameManager.Scoring(150f);
            }
            Destroy(GameObject.FindGameObjectWithTag("active"));
            GameManager.Scoring(100f);
            Cursors.SpawnParticles(success);
        }
        else { }

        if (success == 1)
        {
            HealthBar.HealthBarModifier(300f);
        }
        else if (success == 2)
        {
            HealthBar.HealthBarModifier(150f);
        }
        else if (success == 3)
        {
            HealthBar.HealthBarModifier(100f);
        }
    }
}
