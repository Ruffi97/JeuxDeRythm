using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField]
    private Renderer _CursorUp;
    [SerializeField]
    private Renderer _CursorDown;
    [SerializeField]
    private Renderer _CursorLeft;
    [SerializeField]
    private Renderer _CursorRight;

    void Start()
    {
     
    }

  
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _CursorUp.material.color = Color.white;
            _CursorDown.material.color = Color.grey;
            _CursorLeft.material.color = Color.grey;
            _CursorRight.material.color = Color.grey;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        { 
            _CursorDown.material.color = Color.white;
            _CursorUp.material.color = Color.grey;
            _CursorLeft.material.color = Color.grey;
            _CursorRight.material.color = Color.grey;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            _CursorLeft.material.color = Color.white;
            _CursorDown.material.color = Color.grey;
            _CursorUp.material.color = Color.grey;
            _CursorRight.material.color = Color.grey;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            _CursorRight.material.color = Color.white;
            _CursorDown.material.color = Color.grey;
            _CursorLeft.material.color = Color.grey;
            _CursorUp.material.color = Color.grey;
        }
    }
}
