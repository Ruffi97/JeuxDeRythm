using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class synchro : MonoBehaviour
{
    private float _timer;
    private StreamWriter sw;
    private void Awake()
    {
        try
        {
            sw = new StreamWriter("A:\\Users\\Geo\\Documents\\GitHub\\JeuxDeRythm\\Assets\\Test.txt");
        }
        catch(Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        finally
        {
            Console.WriteLine("Executing finally block.");
        }
    }
    
    void FixedUpdate()
    {
        _timer += Time.deltaTime;

        if (Input.GetButtonDown("Jump"))
        {
            sw.WriteLine(_timer);
            
        }
    }
}
