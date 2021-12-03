using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timer : MonoBehaviour
{
    private float timerui = 0.0f;

    void Update()
    {
        timerui += Time.deltaTime;

        /*while (timerui != 190)
        {
            if (timerui == 60 || timerui == 120 || timerui == 180)
            {
                Debug.Log(timerui);
            }
        }
        Debug.Log(timerui + "Temps écoulés");*/
        
        
    }
}
