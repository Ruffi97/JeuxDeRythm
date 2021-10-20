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
           
        }
        else { CursorUp.material.color = Color.grey; }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            CursorDown.material.color = Color.white;
        }
        else { CursorDown.material.color = Color.grey; }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            CursorLeft.material.color = Color.white;
        }
        else { CursorLeft.material.color = Color.grey; }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            CursorRight.material.color = Color.white;
        }
        else { CursorRight.material.color = Color.grey; }
    }
}
