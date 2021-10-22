using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField]
    private Renderer CursorUp;
    [SerializeField]
    private Renderer CursorDown;
    [SerializeField]
    private Renderer CursorLeft;
    [SerializeField]
    private Renderer CursorRight;

    void Start()
    {
     
    }

  
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            CursorUp.material.color = Color.white;
            CursorDown.material.color = Color.grey;
            CursorLeft.material.color = Color.grey;
            CursorRight.material.color = Color.grey;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        { 
            CursorDown.material.color = Color.white;
            CursorUp.material.color = Color.grey;
            CursorLeft.material.color = Color.grey;
            CursorRight.material.color = Color.grey;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            CursorLeft.material.color = Color.white;
            CursorDown.material.color = Color.grey;
            CursorUp.material.color = Color.grey;
            CursorRight.material.color = Color.grey;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            CursorRight.material.color = Color.white;
            CursorDown.material.color = Color.grey;
            CursorLeft.material.color = Color.grey;
            CursorUp.material.color = Color.grey;
        }
    }
    
}
