using UnityEngine;
using UnityEngine.EventSystems;

public class HubControls : MonoBehaviour
{
    public GameObject menuFirstButton;
    void Start()
    {
        EventSystem.current.SetSelectedGameObject(null);
        EventSystem.current.SetSelectedGameObject(menuFirstButton);
    }
    void Update()
    {
    }
}
