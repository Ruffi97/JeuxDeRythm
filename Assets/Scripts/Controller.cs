using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField]
    private GameObject CursorUp;
    [SerializeField]
    private GameObject CursorDown;
    [SerializeField]
    private GameObject CursorLeft;
    [SerializeField]
    private GameObject CursorRight;

    private Renderer CursorUpRenderer;

    void Start()
    {
        CursorUpRenderer = CursorUp.GetComponent<Renderer>();
    }

  
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            CursorUpRenderer.material.SetColor("_IsSelected", Color.white);
           
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

        }
    }
}
