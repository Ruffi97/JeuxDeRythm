using System;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class HubControls : MonoBehaviour
{
    
    public bool OptionsElements;
    public GameObject menuFirstButton;
    public GameObject MasterSlider; 
    
    void Start()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(menuFirstButton);
    }
}
