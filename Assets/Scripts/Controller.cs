using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField]
    private Renderer _cursorUp;
    [SerializeField]
    private Renderer _cursorDown;
    [SerializeField]
    private Renderer _cursorLeft;
    [SerializeField]
    private Renderer _cursorRight;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _cursorUp.material.color = Color.white;
            _cursorDown.material.color = Color.grey;
            _cursorLeft.material.color = Color.grey;
            _cursorRight.material.color = Color.grey;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        { 
            _cursorDown.material.color = Color.white;
            _cursorUp.material.color = Color.grey;
            _cursorLeft.material.color = Color.grey;
            _cursorRight.material.color = Color.grey;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            _cursorLeft.material.color = Color.white;
            _cursorDown.material.color = Color.grey;
            _cursorUp.material.color = Color.grey;
            _cursorRight.material.color = Color.grey;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            _cursorRight.material.color = Color.white;
            _cursorDown.material.color = Color.grey;
            _cursorLeft.material.color = Color.grey;
            _cursorUp.material.color = Color.grey;
        }
    }
}
